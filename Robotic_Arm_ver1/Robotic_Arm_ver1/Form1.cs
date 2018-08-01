using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace Robotic_Arm_ver1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        String portName;
        int baudRate = 9600, maxNumericAmt;

        String moveHorizCommand, moveVertCommand, setNewSceenSizeCommand;

        public Form1()
        {
            InitializeComponent();

            grayOutObjects(true);
            openPortBtn.BackColor = Color.LightGreen;

            maxNumericAmt = 1000;

            moveHorizCommand = "moveHoriz";
            moveVertCommand = "moveVert";
            setNewSceenSizeCommand = "setScreenSize";

            moveHorizNumeric.Maximum = maxNumericAmt;
            moveVertNumeric.Maximum = maxNumericAmt;
            tapDurNumeric.Maximum = 9999999;

            tapDurNumeric.Value = 1000;  // 1 second

            serialPort = new SerialPort();
            getAvailablePorts();
        }

        public void grayOutObjects(bool grayedOut)
        {
            grayedOut = !grayedOut;

            moveHorizBtn.Enabled = grayedOut;
            moveHorizNumeric.Enabled = grayedOut;
            leftRadio.Enabled = grayedOut;
            rightRadio.Enabled = grayedOut;
            resetBtn.Enabled = grayedOut;
            tapBtn.Enabled = grayedOut;
            moveVertBtn.Enabled = grayedOut;
            moveVertNumeric.Enabled = grayedOut;
            downRadio.Enabled = grayedOut;
            upRadio.Enabled = grayedOut;
            pinchBtn.Enabled = grayedOut;
            inRadio.Enabled = grayedOut;
            outRadio.Enabled = grayedOut;
            screenSizeBtn.Enabled = grayedOut;
            newWidthNumeric.Enabled = grayedOut;
            newHeightNumeric.Enabled = grayedOut;
            closePortBtn.Enabled = grayedOut;
            tapDurNumeric.Enabled = grayedOut;
        }

        private void openPortBtn_Click(object sender, EventArgs e)
        {
            serialPort.BaudRate = baudRate;

            try
            {
                if (portNamesComboBox.Text == "")
                {
                    consoleRichText.Text = "Select a port name";
                }
                else
                {
                    serialPort.PortName = portNamesComboBox.Text;
                    serialPort.Open();
                    progressBar.Value = 50; 
                    resetPos();
                    progressBar.Value = 100;

                    // objects enabled 
                    grayOutObjects(false);
                    portNamesComboBox.Enabled = false;
                    openPortBtn.Enabled = false;
                    openPortBtn.BackColor = SystemColors.Window;
                    closePortBtn.BackColor = Color.Red;
                    consoleRichText.Text = "";

                }
                
            }
            catch (InvalidOperationException) { }
            catch (UnauthorizedAccessException) { }
            catch (TimeoutException) { }
        }

        private void closePortBtn_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            grayOutObjects(true);
            openPortBtn.BackColor = Color.LightGreen;
            closePortBtn.BackColor = SystemColors.Window;
            openPortBtn.Enabled = true;
            portNamesComboBox.Enabled = true;
            progressBar.Value = 0;
            consoleRichText.Text = "";
        }

        private void moveHorizBtn_Click(object sender, EventArgs e)
        {
            int moveHorizAmtText = Convert.ToInt32(moveHorizNumeric.Value);
            if (leftRadio.Checked && moveHorizAmtText > 0) moveHorizAmtText *= -1;
            else if (!leftRadio.Checked && !rightRadio.Checked || moveHorizAmtText <= 0)
            {
                consoleRichText.Text = "ERROR: ('Move Horizontal' button was pressed)\nEnter a direction and/or amount greater than 0";
                return;
            }
            serialPort.Write(moveHorizCommand + "(" + Convert.ToString(moveHorizAmtText) + ")");
            try
            {
                consoleRichText.Text = serialPort.ReadLine();
            }
            catch (TimeoutException)
            {
                consoleRichText.Text = "Timeout Exception";
            }            
            serialPort.Write("getCurrXpos");
            currXpos.Text = serialPort.ReadLine();
        }

        private void moveVertBtn_Click(object sender, EventArgs e)
        {
            int moveVertAmtText = Convert.ToInt32(moveVertNumeric.Value);
            if (downRadio.Checked && moveVertAmtText > 0) moveVertAmtText *= -1;
            else if (!upRadio.Checked && !downRadio.Checked || moveVertAmtText <= 0)
            {
                consoleRichText.Text = "ERROR: ('Move Vertical' button was pressed)\nEnter a direction and/or amount greater than 0";
                return;
            }
            serialPort.Write(moveVertCommand + "(" + Convert.ToString(moveVertAmtText) + ")");
            try
            {
                consoleRichText.Text = serialPort.ReadLine();
            }
            catch (TimeoutException)
            {
                consoleRichText.Text = "Timeout Exception";
            }
            serialPort.Write("getCurrYpos");
            currYpos.Text = serialPort.ReadLine();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (currXpos.Text.Equals("0") && currYpos.Text.Equals("0"))
            {
                consoleRichText.Text = "Position is already at (0,0)";
            }
            else if (currXpos.Text.Equals("0") || currYpos.Text.Equals("0"))
            {
                serialPort.Write("reset");
                consoleRichText.Text = serialPort.ReadLine() + serialPort.ReadLine();
                currXpos.Text = "0"; currYpos.Text = "0";
            }
            else
            {
                serialPort.Write("reset");
                consoleRichText.Text = serialPort.ReadLine() + serialPort.ReadLine() + serialPort.ReadLine();
                currXpos.Text = "0"; currYpos.Text = "0";
            }
        }
        
        private void resetPos()
        {
            serialPort.Write("getCurrXpos");
            int currX = Convert.ToInt32(serialPort.ReadLine());
            serialPort.Write("getCurrYpos");
            int currY = Convert.ToInt32(serialPort.ReadLine());

            if (currX == 0 && currY == 0)
            {
                
            }
            else if (currX == 0 || currY == 0)
            {
                serialPort.Write("reset");
                serialPort.ReadLine();  serialPort.ReadLine();
                currXpos.Text = "0"; currYpos.Text = "0";
            }
            else
            {
                serialPort.Write("reset");
                serialPort.ReadLine(); serialPort.ReadLine(); serialPort.ReadLine();
                currXpos.Text = "0"; currYpos.Text = "0";
            }
        }

        private void screenSizeBtn_Click(object sender, EventArgs e)
        { 
            String newWidth = Convert.ToString(newWidthNumeric.Value);
            String newHeight = Convert.ToString(newHeightNumeric.Value);

            serialPort.Write(setNewSceenSizeCommand + "(" + newWidth + "," + newHeight + ")");
            consoleRichText.Text = serialPort.ReadLine() + serialPort.ReadLine();
        }

        private void getAvailablePorts()
        {
            String[] portNames = SerialPort.GetPortNames();
            portNamesComboBox.Items.AddRange(portNames);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tapDurNumeric.Enabled == true) {
                tapDurNumeric.Enabled = false;
            } else
            {
                tapDurNumeric.Enabled = true;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            consoleRichText.Text = "";
        }

        private void tapBtn_Click(object sender, EventArgs e)
        {
            if (doubleTapCheckBox.Checked)
            {
                serialPort.Write("tap(0,true)");
                consoleRichText.Text = serialPort.ReadLine();
            }
            else
            {

                int tapDur = Convert.ToInt32(tapDurNumeric.Value);

                consoleRichText.Text = "Tapping...\n";

                serialPort.Write("tap(" + Convert.ToString(tapDur) + ")");
                consoleRichText.Text += serialPort.ReadLine();
            }
        }

        private void pinchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
