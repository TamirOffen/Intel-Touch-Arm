namespace Robotic_Arm_ver1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currYpos = new System.Windows.Forms.Label();
            this.currXpos = new System.Windows.Forms.Label();
            this.currYposLabel = new System.Windows.Forms.Label();
            this.currXposLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.consoleRichText = new System.Windows.Forms.RichTextBox();
            this.newWidthLabel = new System.Windows.Forms.Label();
            this.newHeightLabel = new System.Windows.Forms.Label();
            this.newHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.newWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.screenSizeBtn = new System.Windows.Forms.Button();
            this.inRadio = new System.Windows.Forms.RadioButton();
            this.outRadio = new System.Windows.Forms.RadioButton();
            this.pinchBtn = new System.Windows.Forms.Button();
            this.tapBtn = new System.Windows.Forms.Button();
            this.resetRichText = new System.Windows.Forms.RichTextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.moveVertNumeric = new System.Windows.Forms.NumericUpDown();
            this.upRadio = new System.Windows.Forms.RadioButton();
            this.downRadio = new System.Windows.Forms.RadioButton();
            this.moveVertLabel = new System.Windows.Forms.Label();
            this.moveVertBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rightRadio = new System.Windows.Forms.RadioButton();
            this.leftRadio = new System.Windows.Forms.RadioButton();
            this.moveHorizLabel = new System.Windows.Forms.Label();
            this.moveHorizBtn = new System.Windows.Forms.Button();
            this.moveHorizNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.closePortBtn = new System.Windows.Forms.Button();
            this.openPortBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.portNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tapDurrText = new System.Windows.Forms.Label();
            this.tapDurNumeric = new System.Windows.Forms.NumericUpDown();
            this.doubleTapCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.newHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveVertNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveHorizNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tapDurNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // currYpos
            // 
            this.currYpos.AutoSize = true;
            this.currYpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currYpos.ForeColor = System.Drawing.Color.Red;
            this.currYpos.Location = new System.Drawing.Point(144, 347);
            this.currYpos.Name = "currYpos";
            this.currYpos.Size = new System.Drawing.Size(29, 31);
            this.currYpos.TabIndex = 75;
            this.currYpos.Text = "0";
            // 
            // currXpos
            // 
            this.currXpos.AutoSize = true;
            this.currXpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currXpos.ForeColor = System.Drawing.Color.Red;
            this.currXpos.Location = new System.Drawing.Point(144, 304);
            this.currXpos.Name = "currXpos";
            this.currXpos.Size = new System.Drawing.Size(29, 31);
            this.currXpos.TabIndex = 74;
            this.currXpos.Text = "0";
            // 
            // currYposLabel
            // 
            this.currYposLabel.AutoSize = true;
            this.currYposLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.currYposLabel.ForeColor = System.Drawing.Color.Teal;
            this.currYposLabel.Location = new System.Drawing.Point(23, 349);
            this.currYposLabel.Name = "currYposLabel";
            this.currYposLabel.Size = new System.Drawing.Size(128, 29);
            this.currYposLabel.TabIndex = 73;
            this.currYposLabel.Text = "Y Position:";
            // 
            // currXposLabel
            // 
            this.currXposLabel.AutoSize = true;
            this.currXposLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.currXposLabel.ForeColor = System.Drawing.Color.Teal;
            this.currXposLabel.Location = new System.Drawing.Point(23, 304);
            this.currXposLabel.Name = "currXposLabel";
            this.currXposLabel.Size = new System.Drawing.Size(129, 29);
            this.currXposLabel.TabIndex = 72;
            this.currXposLabel.Text = "X Position:";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.clearBtn.Location = new System.Drawing.Point(229, 349);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(64, 30);
            this.clearBtn.TabIndex = 71;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.consoleLabel.Location = new System.Drawing.Point(199, 307);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(114, 31);
            this.consoleLabel.TabIndex = 70;
            this.consoleLabel.Text = "Console";
            // 
            // consoleRichText
            // 
            this.consoleRichText.Enabled = false;
            this.consoleRichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.consoleRichText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.consoleRichText.Location = new System.Drawing.Point(313, 302);
            this.consoleRichText.Name = "consoleRichText";
            this.consoleRichText.Size = new System.Drawing.Size(416, 95);
            this.consoleRichText.TabIndex = 69;
            this.consoleRichText.Text = "";
            // 
            // newWidthLabel
            // 
            this.newWidthLabel.AutoSize = true;
            this.newWidthLabel.Location = new System.Drawing.Point(649, 213);
            this.newWidthLabel.Name = "newWidthLabel";
            this.newWidthLabel.Size = new System.Drawing.Size(63, 13);
            this.newWidthLabel.TabIndex = 68;
            this.newWidthLabel.Text = "New Width:";
            // 
            // newHeightLabel
            // 
            this.newHeightLabel.AutoSize = true;
            this.newHeightLabel.Location = new System.Drawing.Point(647, 243);
            this.newHeightLabel.Name = "newHeightLabel";
            this.newHeightLabel.Size = new System.Drawing.Size(66, 13);
            this.newHeightLabel.TabIndex = 67;
            this.newHeightLabel.Text = "New Height:";
            // 
            // newHeightNumeric
            // 
            this.newHeightNumeric.Location = new System.Drawing.Point(713, 239);
            this.newHeightNumeric.Name = "newHeightNumeric";
            this.newHeightNumeric.Size = new System.Drawing.Size(51, 20);
            this.newHeightNumeric.TabIndex = 66;
            // 
            // newWidthNumeric
            // 
            this.newWidthNumeric.Location = new System.Drawing.Point(712, 210);
            this.newWidthNumeric.Name = "newWidthNumeric";
            this.newWidthNumeric.Size = new System.Drawing.Size(51, 20);
            this.newWidthNumeric.TabIndex = 65;
            // 
            // screenSizeBtn
            // 
            this.screenSizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.screenSizeBtn.Location = new System.Drawing.Point(509, 199);
            this.screenSizeBtn.Name = "screenSizeBtn";
            this.screenSizeBtn.Size = new System.Drawing.Size(139, 74);
            this.screenSizeBtn.TabIndex = 64;
            this.screenSizeBtn.Text = "Set New Screen Size";
            this.screenSizeBtn.UseVisualStyleBackColor = true;
            this.screenSizeBtn.Click += new System.EventHandler(this.screenSizeBtn_Click);
            // 
            // inRadio
            // 
            this.inRadio.AutoSize = true;
            this.inRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inRadio.Location = new System.Drawing.Point(385, 210);
            this.inRadio.Name = "inRadio";
            this.inRadio.Size = new System.Drawing.Size(42, 26);
            this.inRadio.TabIndex = 63;
            this.inRadio.TabStop = true;
            this.inRadio.Text = "In";
            this.inRadio.UseVisualStyleBackColor = true;
            // 
            // outRadio
            // 
            this.outRadio.AutoSize = true;
            this.outRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.outRadio.Location = new System.Drawing.Point(385, 239);
            this.outRadio.Name = "outRadio";
            this.outRadio.Size = new System.Drawing.Size(57, 26);
            this.outRadio.TabIndex = 62;
            this.outRadio.TabStop = true;
            this.outRadio.Text = "Out";
            this.outRadio.UseVisualStyleBackColor = true;
            // 
            // pinchBtn
            // 
            this.pinchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pinchBtn.Location = new System.Drawing.Point(232, 199);
            this.pinchBtn.Name = "pinchBtn";
            this.pinchBtn.Size = new System.Drawing.Size(139, 74);
            this.pinchBtn.TabIndex = 61;
            this.pinchBtn.Text = "Pinch";
            this.pinchBtn.UseVisualStyleBackColor = true;
            this.pinchBtn.Click += new System.EventHandler(this.pinchBtn_Click);
            // 
            // tapBtn
            // 
            this.tapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tapBtn.Location = new System.Drawing.Point(511, 95);
            this.tapBtn.Name = "tapBtn";
            this.tapBtn.Size = new System.Drawing.Size(139, 74);
            this.tapBtn.TabIndex = 59;
            this.tapBtn.Text = "Tap";
            this.tapBtn.UseVisualStyleBackColor = true;
            this.tapBtn.Click += new System.EventHandler(this.tapBtn_Click);
            // 
            // resetRichText
            // 
            this.resetRichText.Enabled = false;
            this.resetRichText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetRichText.Location = new System.Drawing.Point(377, 102);
            this.resetRichText.Name = "resetRichText";
            this.resetRichText.Size = new System.Drawing.Size(107, 58);
            this.resetRichText.TabIndex = 58;
            this.resetRichText.Text = "Resets the position of the arm to (0,0) [bottom left]\n";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.resetBtn.Location = new System.Drawing.Point(232, 95);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(139, 74);
            this.resetBtn.TabIndex = 57;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // moveVertNumeric
            // 
            this.moveVertNumeric.Location = new System.Drawing.Point(99, 37);
            this.moveVertNumeric.Name = "moveVertNumeric";
            this.moveVertNumeric.Size = new System.Drawing.Size(70, 20);
            this.moveVertNumeric.TabIndex = 56;
            // 
            // upRadio
            // 
            this.upRadio.AutoSize = true;
            this.upRadio.Location = new System.Drawing.Point(146, 61);
            this.upRadio.Name = "upRadio";
            this.upRadio.Size = new System.Drawing.Size(39, 17);
            this.upRadio.TabIndex = 55;
            this.upRadio.TabStop = true;
            this.upRadio.Text = "Up";
            this.upRadio.UseVisualStyleBackColor = true;
            // 
            // downRadio
            // 
            this.downRadio.AutoSize = true;
            this.downRadio.Location = new System.Drawing.Point(89, 61);
            this.downRadio.Name = "downRadio";
            this.downRadio.Size = new System.Drawing.Size(53, 17);
            this.downRadio.TabIndex = 54;
            this.downRadio.TabStop = true;
            this.downRadio.Text = "Down";
            this.downRadio.UseVisualStyleBackColor = true;
            // 
            // moveVertLabel
            // 
            this.moveVertLabel.AutoSize = true;
            this.moveVertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moveVertLabel.Location = new System.Drawing.Point(3, 13);
            this.moveVertLabel.Name = "moveVertLabel";
            this.moveVertLabel.Size = new System.Drawing.Size(104, 20);
            this.moveVertLabel.TabIndex = 53;
            this.moveVertLabel.Text = "Move Vertical";
            // 
            // moveVertBtn
            // 
            this.moveVertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.moveVertBtn.Location = new System.Drawing.Point(6, 32);
            this.moveVertBtn.Name = "moveVertBtn";
            this.moveVertBtn.Size = new System.Drawing.Size(72, 46);
            this.moveVertBtn.TabIndex = 52;
            this.moveVertBtn.Text = "Move";
            this.moveVertBtn.UseVisualStyleBackColor = true;
            this.moveVertBtn.Click += new System.EventHandler(this.moveVertBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightRadio);
            this.groupBox1.Controls.Add(this.leftRadio);
            this.groupBox1.Controls.Add(this.moveHorizLabel);
            this.groupBox1.Controls.Add(this.moveHorizBtn);
            this.groupBox1.Controls.Add(this.moveHorizNumeric);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // rightRadio
            // 
            this.rightRadio.AutoSize = true;
            this.rightRadio.Location = new System.Drawing.Point(142, 65);
            this.rightRadio.Name = "rightRadio";
            this.rightRadio.Size = new System.Drawing.Size(50, 17);
            this.rightRadio.TabIndex = 55;
            this.rightRadio.TabStop = true;
            this.rightRadio.Text = "Right";
            this.rightRadio.UseVisualStyleBackColor = true;
            // 
            // leftRadio
            // 
            this.leftRadio.AutoSize = true;
            this.leftRadio.Location = new System.Drawing.Point(91, 65);
            this.leftRadio.Name = "leftRadio";
            this.leftRadio.Size = new System.Drawing.Size(43, 17);
            this.leftRadio.TabIndex = 54;
            this.leftRadio.TabStop = true;
            this.leftRadio.Text = "Left";
            this.leftRadio.UseVisualStyleBackColor = true;
            // 
            // moveHorizLabel
            // 
            this.moveHorizLabel.AutoSize = true;
            this.moveHorizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moveHorizLabel.Location = new System.Drawing.Point(6, 16);
            this.moveHorizLabel.Name = "moveHorizLabel";
            this.moveHorizLabel.Size = new System.Drawing.Size(123, 20);
            this.moveHorizLabel.TabIndex = 53;
            this.moveHorizLabel.Text = "Move Horizontal";
            // 
            // moveHorizBtn
            // 
            this.moveHorizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.moveHorizBtn.Location = new System.Drawing.Point(9, 35);
            this.moveHorizBtn.Name = "moveHorizBtn";
            this.moveHorizBtn.Size = new System.Drawing.Size(72, 46);
            this.moveHorizBtn.TabIndex = 52;
            this.moveHorizBtn.Text = "Move";
            this.moveHorizBtn.UseVisualStyleBackColor = true;
            this.moveHorizBtn.Click += new System.EventHandler(this.moveHorizBtn_Click);
            // 
            // moveHorizNumeric
            // 
            this.moveHorizNumeric.Location = new System.Drawing.Point(102, 40);
            this.moveHorizNumeric.Name = "moveHorizNumeric";
            this.moveHorizNumeric.Size = new System.Drawing.Size(70, 20);
            this.moveHorizNumeric.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moveVertBtn);
            this.groupBox2.Controls.Add(this.moveVertLabel);
            this.groupBox2.Controls.Add(this.downRadio);
            this.groupBox2.Controls.Add(this.upRadio);
            this.groupBox2.Controls.Add(this.moveVertNumeric);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.closePortBtn);
            this.groupBox3.Controls.Add(this.openPortBtn);
            this.groupBox3.Controls.Add(this.progressBar);
            this.groupBox3.Controls.Add(this.portNamesComboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(51, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 62);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            // 
            // closePortBtn
            // 
            this.closePortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.closePortBtn.Location = new System.Drawing.Point(379, 16);
            this.closePortBtn.Name = "closePortBtn";
            this.closePortBtn.Size = new System.Drawing.Size(126, 37);
            this.closePortBtn.TabIndex = 85;
            this.closePortBtn.Text = "Close Port";
            this.closePortBtn.UseVisualStyleBackColor = true;
            this.closePortBtn.Click += new System.EventHandler(this.closePortBtn_Click);
            // 
            // openPortBtn
            // 
            this.openPortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.openPortBtn.Location = new System.Drawing.Point(247, 16);
            this.openPortBtn.Name = "openPortBtn";
            this.openPortBtn.Size = new System.Drawing.Size(126, 37);
            this.openPortBtn.TabIndex = 83;
            this.openPortBtn.Text = "Open Port";
            this.openPortBtn.UseVisualStyleBackColor = true;
            this.openPortBtn.Click += new System.EventHandler(this.openPortBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(525, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(115, 23);
            this.progressBar.TabIndex = 84;
            // 
            // portNamesComboBox
            // 
            this.portNamesComboBox.FormattingEnabled = true;
            this.portNamesComboBox.Location = new System.Drawing.Point(108, 25);
            this.portNamesComboBox.Name = "portNamesComboBox";
            this.portNamesComboBox.Size = new System.Drawing.Size(121, 21);
            this.portNamesComboBox.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Port Names:";
            // 
            // tapDurrText
            // 
            this.tapDurrText.AutoSize = true;
            this.tapDurrText.Location = new System.Drawing.Point(649, 105);
            this.tapDurrText.Name = "tapDurrText";
            this.tapDurrText.Size = new System.Drawing.Size(139, 13);
            this.tapDurrText.TabIndex = 109;
            this.tapDurrText.Text = "Tap Duration in milliseconds";
            // 
            // tapDurNumeric
            // 
            this.tapDurNumeric.Location = new System.Drawing.Point(673, 128);
            this.tapDurNumeric.Name = "tapDurNumeric";
            this.tapDurNumeric.Size = new System.Drawing.Size(90, 20);
            this.tapDurNumeric.TabIndex = 108;
            // 
            // doubleTapCheckBox
            // 
            this.doubleTapCheckBox.AutoSize = true;
            this.doubleTapCheckBox.Location = new System.Drawing.Point(677, 152);
            this.doubleTapCheckBox.Name = "doubleTapCheckBox";
            this.doubleTapCheckBox.Size = new System.Drawing.Size(82, 17);
            this.doubleTapCheckBox.TabIndex = 110;
            this.doubleTapCheckBox.Text = "Double Tap";
            this.doubleTapCheckBox.UseVisualStyleBackColor = true;
            this.doubleTapCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 415);
            this.Controls.Add(this.doubleTapCheckBox);
            this.Controls.Add(this.tapDurrText);
            this.Controls.Add(this.tapDurNumeric);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currYpos);
            this.Controls.Add(this.currXpos);
            this.Controls.Add(this.currYposLabel);
            this.Controls.Add(this.currXposLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.consoleRichText);
            this.Controls.Add(this.newWidthLabel);
            this.Controls.Add(this.newHeightLabel);
            this.Controls.Add(this.newHeightNumeric);
            this.Controls.Add(this.newWidthNumeric);
            this.Controls.Add(this.screenSizeBtn);
            this.Controls.Add(this.inRadio);
            this.Controls.Add(this.outRadio);
            this.Controls.Add(this.pinchBtn);
            this.Controls.Add(this.tapBtn);
            this.Controls.Add(this.resetRichText);
            this.Controls.Add(this.resetBtn);
            this.Name = "Form1";
            this.Text = "Robotic Arm";
            ((System.ComponentModel.ISupportInitialize)(this.newHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveVertNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveHorizNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tapDurNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currYpos;
        private System.Windows.Forms.Label currXpos;
        private System.Windows.Forms.Label currYposLabel;
        private System.Windows.Forms.Label currXposLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.RichTextBox consoleRichText;
        private System.Windows.Forms.Label newWidthLabel;
        private System.Windows.Forms.Label newHeightLabel;
        private System.Windows.Forms.NumericUpDown newHeightNumeric;
        private System.Windows.Forms.NumericUpDown newWidthNumeric;
        private System.Windows.Forms.Button screenSizeBtn;
        private System.Windows.Forms.RadioButton inRadio;
        private System.Windows.Forms.RadioButton outRadio;
        private System.Windows.Forms.Button pinchBtn;
        private System.Windows.Forms.Button tapBtn;
        private System.Windows.Forms.RichTextBox resetRichText;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.NumericUpDown moveVertNumeric;
        private System.Windows.Forms.RadioButton upRadio;
        private System.Windows.Forms.RadioButton downRadio;
        private System.Windows.Forms.Label moveVertLabel;
        private System.Windows.Forms.Button moveVertBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rightRadio;
        private System.Windows.Forms.RadioButton leftRadio;
        private System.Windows.Forms.Label moveHorizLabel;
        private System.Windows.Forms.Button moveHorizBtn;
        private System.Windows.Forms.NumericUpDown moveHorizNumeric;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button openPortBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox portNamesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closePortBtn;
        private System.Windows.Forms.Label tapDurrText;
        private System.Windows.Forms.NumericUpDown tapDurNumeric;
        private System.Windows.Forms.CheckBox doubleTapCheckBox;
    }
}

