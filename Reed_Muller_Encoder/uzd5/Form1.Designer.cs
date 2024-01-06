namespace uzd5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rBtnBinary = new RadioButton();
            rBtnSentence = new RadioButton();
            rBtnPhoto = new RadioButton();
            txtIndex = new TextBox();
            lblIndex = new Label();
            lblType = new Label();
            btnCalculate = new Button();
            lblBitSequence = new Label();
            txtBitSequence = new TextBox();
            gBoxBinary = new GroupBox();
            btnContinue = new Button();
            lblAmount = new Label();
            lblCompare = new Label();
            txtChange = new TextBox();
            cboxChange = new CheckBox();
            lblCarry = new Label();
            lblDistorted = new Label();
            lblEntered = new Label();
            lblEncoded = new Label();
            gBoxPhoto = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDirectory = new TextBox();
            pBoxEncoded = new PictureBox();
            pBoxNotEncoded = new PictureBox();
            pBoxOriginal = new PictureBox();
            gBoxSentence = new GroupBox();
            lblDistortedSentence = new Label();
            lblEntereSentence = new Label();
            txtSentence = new TextBox();
            lblDecodedSentence = new Label();
            lblDistortation = new Label();
            txtDistortation = new TextBox();
            gBoxBinary.SuspendLayout();
            gBoxPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxEncoded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxNotEncoded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxOriginal).BeginInit();
            gBoxSentence.SuspendLayout();
            SuspendLayout();
            // 
            // rBtnBinary
            // 
            rBtnBinary.AutoSize = true;
            rBtnBinary.Checked = true;
            rBtnBinary.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnBinary.Location = new Point(12, 83);
            rBtnBinary.Name = "rBtnBinary";
            rBtnBinary.Size = new Size(130, 19);
            rBtnBinary.TabIndex = 0;
            rBtnBinary.TabStop = true;
            rBtnBinary.Text = "Binary Sequence";
            rBtnBinary.UseVisualStyleBackColor = true;
            rBtnBinary.CheckedChanged += RBtnBinary_CheckedChanged;
            // 
            // rBtnSentence
            // 
            rBtnSentence.AutoSize = true;
            rBtnSentence.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnSentence.Location = new Point(12, 108);
            rBtnSentence.Name = "rBtnSentence";
            rBtnSentence.Size = new Size(81, 19);
            rBtnSentence.TabIndex = 1;
            rBtnSentence.Text = "Sentence";
            rBtnSentence.UseVisualStyleBackColor = true;
            rBtnSentence.CheckedChanged += RBtnSentence_CheckedChanged;
            // 
            // rBtnPhoto
            // 
            rBtnPhoto.AutoSize = true;
            rBtnPhoto.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnPhoto.Location = new Point(12, 133);
            rBtnPhoto.Name = "rBtnPhoto";
            rBtnPhoto.Size = new Size(60, 19);
            rBtnPhoto.TabIndex = 2;
            rBtnPhoto.Text = "Image";
            rBtnPhoto.UseVisualStyleBackColor = true;
            rBtnPhoto.CheckedChanged += RBtnPhoto_CheckedChanged;
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(12, 31);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(35, 21);
            txtIndex.TabIndex = 3;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIndex.Location = new Point(12, 9);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(196, 15);
            lblIndex.TabIndex = 4;
            lblIndex.Text = "1. Enter Reed-Muller index:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblType.Location = new Point(12, 58);
            lblType.Name = "lblType";
            lblType.Size = new Size(112, 15);
            lblType.TabIndex = 5;
            lblType.Text = "2. Choose Type:";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(10, 262);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(103, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // lblBitSequence
            // 
            lblBitSequence.AutoSize = true;
            lblBitSequence.Location = new Point(5, 17);
            lblBitSequence.Name = "lblBitSequence";
            lblBitSequence.Size = new Size(154, 14);
            lblBitSequence.TabIndex = 8;
            lblBitSequence.Text = "3. Enter bit sequence";
            // 
            // txtBitSequence
            // 
            txtBitSequence.Location = new Point(5, 43);
            txtBitSequence.Name = "txtBitSequence";
            txtBitSequence.Size = new Size(484, 20);
            txtBitSequence.TabIndex = 9;
            // 
            // gBoxBinary
            // 
            gBoxBinary.Controls.Add(btnContinue);
            gBoxBinary.Controls.Add(lblAmount);
            gBoxBinary.Controls.Add(lblCompare);
            gBoxBinary.Controls.Add(txtChange);
            gBoxBinary.Controls.Add(cboxChange);
            gBoxBinary.Controls.Add(lblCarry);
            gBoxBinary.Controls.Add(lblDistorted);
            gBoxBinary.Controls.Add(lblEntered);
            gBoxBinary.Controls.Add(lblEncoded);
            gBoxBinary.Controls.Add(lblBitSequence);
            gBoxBinary.Controls.Add(txtBitSequence);
            gBoxBinary.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            gBoxBinary.Location = new Point(186, 39);
            gBoxBinary.Margin = new Padding(3, 2, 3, 2);
            gBoxBinary.Name = "gBoxBinary";
            gBoxBinary.Padding = new Padding(3, 2, 3, 2);
            gBoxBinary.Size = new Size(538, 246);
            gBoxBinary.TabIndex = 10;
            gBoxBinary.TabStop = false;
            gBoxBinary.Text = "Binary";
            // 
            // btnContinue
            // 
            btnContinue.Enabled = false;
            btnContinue.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinue.Location = new Point(495, 152);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(34, 24);
            btnContinue.TabIndex = 14;
            btnContinue.Text = "Ok";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(5, 118);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(189, 14);
            lblAmount.TabIndex = 17;
            lblAmount.Text = "Amount of distorted bits: ";
            // 
            // lblCompare
            // 
            lblCompare.AutoSize = true;
            lblCompare.Location = new Point(5, 100);
            lblCompare.Name = "lblCompare";
            lblCompare.Size = new Size(91, 14);
            lblCompare.TabIndex = 16;
            lblCompare.Text = "Differences:";
            // 
            // txtChange
            // 
            txtChange.Enabled = false;
            txtChange.Location = new Point(7, 154);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(483, 20);
            txtChange.TabIndex = 14;
            // 
            // cboxChange
            // 
            cboxChange.AutoSize = true;
            cboxChange.Location = new Point(7, 134);
            cboxChange.Name = "cboxChange";
            cboxChange.Size = new Size(138, 18);
            cboxChange.TabIndex = 15;
            cboxChange.Text = "Change sequence?";
            cboxChange.UseVisualStyleBackColor = true;
            cboxChange.CheckedChanged += cboxChange_CheckedChanged;
            // 
            // lblCarry
            // 
            lblCarry.AutoSize = true;
            lblCarry.Location = new Point(52, 217);
            lblCarry.Name = "lblCarry";
            lblCarry.Size = new Size(406, 14);
            lblCarry.TabIndex = 13;
            lblCarry.Text = "Important!! Last bit was carried over not using encoding.";
            lblCarry.Visible = false;
            // 
            // lblDistorted
            // 
            lblDistorted.AutoSize = true;
            lblDistorted.Location = new Point(5, 84);
            lblDistorted.Name = "lblDistorted";
            lblDistorted.Size = new Size(147, 14);
            lblDistorted.TabIndex = 12;
            lblDistorted.Text = "Distorted sequences:";
            // 
            // lblEntered
            // 
            lblEntered.AutoSize = true;
            lblEntered.Location = new Point(7, 178);
            lblEntered.Name = "lblEntered";
            lblEntered.Size = new Size(154, 14);
            lblEntered.TabIndex = 11;
            lblEntered.Text = "Decoded bit sequence:";
            // 
            // lblEncoded
            // 
            lblEncoded.AutoSize = true;
            lblEncoded.Location = new Point(5, 69);
            lblEncoded.Name = "lblEncoded";
            lblEncoded.Size = new Size(133, 14);
            lblEncoded.TabIndex = 10;
            lblEncoded.Text = "Encoded sequences:";
            // 
            // gBoxPhoto
            // 
            gBoxPhoto.Controls.Add(label4);
            gBoxPhoto.Controls.Add(label3);
            gBoxPhoto.Controls.Add(label2);
            gBoxPhoto.Controls.Add(label1);
            gBoxPhoto.Controls.Add(txtDirectory);
            gBoxPhoto.Controls.Add(pBoxEncoded);
            gBoxPhoto.Controls.Add(pBoxNotEncoded);
            gBoxPhoto.Controls.Add(pBoxOriginal);
            gBoxPhoto.Location = new Point(187, 58);
            gBoxPhoto.Margin = new Padding(3, 2, 3, 2);
            gBoxPhoto.Name = "gBoxPhoto";
            gBoxPhoto.Padding = new Padding(3, 2, 3, 2);
            gBoxPhoto.Size = new Size(870, 381);
            gBoxPhoto.TabIndex = 13;
            gBoxPhoto.TabStop = false;
            gBoxPhoto.Text = "BMP Photo";
            gBoxPhoto.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 326);
            label4.Name = "label4";
            label4.Size = new Size(161, 15);
            label4.TabIndex = 17;
            label4.Text = "Full path to picture: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(614, 290);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 16;
            label3.Text = "Encoded Photo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(352, 290);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 15;
            label2.Text = "Not encoded Photo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 290);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 14;
            label1.Text = "Original Photo";
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(187, 323);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(587, 21);
            txtDirectory.TabIndex = 14;
            // 
            // pBoxEncoded
            // 
            pBoxEncoded.Location = new Point(560, 28);
            pBoxEncoded.Name = "pBoxEncoded";
            pBoxEncoded.Size = new Size(244, 259);
            pBoxEncoded.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxEncoded.TabIndex = 2;
            pBoxEncoded.TabStop = false;
            // 
            // pBoxNotEncoded
            // 
            pBoxNotEncoded.Location = new Point(289, 28);
            pBoxNotEncoded.Name = "pBoxNotEncoded";
            pBoxNotEncoded.Size = new Size(248, 259);
            pBoxNotEncoded.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxNotEncoded.TabIndex = 1;
            pBoxNotEncoded.TabStop = false;
            // 
            // pBoxOriginal
            // 
            pBoxOriginal.Location = new Point(24, 28);
            pBoxOriginal.Name = "pBoxOriginal";
            pBoxOriginal.Size = new Size(236, 259);
            pBoxOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxOriginal.TabIndex = 0;
            pBoxOriginal.TabStop = false;
            // 
            // gBoxSentence
            // 
            gBoxSentence.Controls.Add(lblDistortedSentence);
            gBoxSentence.Controls.Add(lblEntereSentence);
            gBoxSentence.Controls.Add(txtSentence);
            gBoxSentence.Controls.Add(lblDecodedSentence);
            gBoxSentence.Location = new Point(187, 48);
            gBoxSentence.Margin = new Padding(3, 2, 3, 2);
            gBoxSentence.Name = "gBoxSentence";
            gBoxSentence.Padding = new Padding(3, 2, 3, 2);
            gBoxSentence.Size = new Size(537, 219);
            gBoxSentence.TabIndex = 11;
            gBoxSentence.TabStop = false;
            gBoxSentence.Text = "Sentence";
            gBoxSentence.Visible = false;
            // 
            // lblDistortedSentence
            // 
            lblDistortedSentence.Location = new Point(5, 80);
            lblDistortedSentence.Name = "lblDistortedSentence";
            lblDistortedSentence.Size = new Size(523, 67);
            lblDistortedSentence.TabIndex = 11;
            lblDistortedSentence.Text = "Not using encoding:";
            // 
            // lblEntereSentence
            // 
            lblEntereSentence.AutoSize = true;
            lblEntereSentence.Location = new Point(5, 16);
            lblEntereSentence.Name = "lblEntereSentence";
            lblEntereSentence.Size = new Size(140, 15);
            lblEntereSentence.TabIndex = 8;
            lblEntereSentence.Text = "3. Enter a sentence";
            // 
            // txtSentence
            // 
            txtSentence.Location = new Point(5, 43);
            txtSentence.Name = "txtSentence";
            txtSentence.Size = new Size(512, 21);
            txtSentence.TabIndex = 9;
            // 
            // lblDecodedSentence
            // 
            lblDecodedSentence.Location = new Point(4, 147);
            lblDecodedSentence.Name = "lblDecodedSentence";
            lblDecodedSentence.Size = new Size(524, 70);
            lblDecodedSentence.TabIndex = 10;
            lblDecodedSentence.Text = "Using encoding and decoding: ";
            // 
            // lblDistortation
            // 
            lblDistortation.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDistortation.Location = new Point(10, 157);
            lblDistortation.Name = "lblDistortation";
            lblDistortation.Size = new Size(145, 72);
            lblDistortation.TabIndex = 12;
            lblDistortation.Text = "4. Enter Distortation probability (1-10000): ";
            // 
            // txtDistortation
            // 
            txtDistortation.Location = new Point(12, 232);
            txtDistortation.Name = "txtDistortation";
            txtDistortation.Size = new Size(74, 21);
            txtDistortation.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 450);
            Controls.Add(txtDistortation);
            Controls.Add(lblDistortation);
            Controls.Add(btnCalculate);
            Controls.Add(lblType);
            Controls.Add(lblIndex);
            Controls.Add(txtIndex);
            Controls.Add(rBtnPhoto);
            Controls.Add(rBtnSentence);
            Controls.Add(rBtnBinary);
            Controls.Add(gBoxPhoto);
            Controls.Add(gBoxSentence);
            Controls.Add(gBoxBinary);
            Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Reed-Muller Index";
            gBoxBinary.ResumeLayout(false);
            gBoxBinary.PerformLayout();
            gBoxPhoto.ResumeLayout(false);
            gBoxPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxEncoded).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxNotEncoded).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxOriginal).EndInit();
            gBoxSentence.ResumeLayout(false);
            gBoxSentence.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rBtnBinary;
        private RadioButton rBtnSentence;
        private RadioButton rBtnPhoto;
        private TextBox txtIndex;
        private Label lblIndex;
        private Label lblType;
        private Button btnCalculate;
        private Label lblBitSequence;
        private TextBox txtBitSequence;
        private GroupBox gBoxBinary;
        private GroupBox gBoxSentence;
        private Label lblEntereSentence;
        private TextBox txtSentence;
        private Label lblDistortation;
        private TextBox txtDistortation;
        private Label lblEncoded;
        private Label lblEntered;
        private Label lblDistorted;
        private Label lblDecodedSentence;
        private GroupBox gBoxPhoto;
        private PictureBox pBoxOriginal;
        private PictureBox pBoxEncoded;
        private PictureBox pBoxNotEncoded;
        private Label lblDistortedSentence;
        private Label lblCarry;
        private CheckBox cboxChange;
        private TextBox txtChange;
        private Label lblCompare;
        private Label lblAmount;
        private Button btnContinue;
        private TextBox txtDirectory;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}