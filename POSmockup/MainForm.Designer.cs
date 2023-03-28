namespace POSmockup
{
    partial class MainForm
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
            groupBoxPrices = new GroupBox();
            textBoxItem3 = new TextBox();
            textBoxItem2 = new TextBox();
            textBoxItem1 = new TextBox();
            labelItem3 = new Label();
            labelItem2 = new Label();
            labelItem1 = new Label();
            groupBoxSize = new GroupBox();
            label1 = new Label();
            buttonItemAdd = new Button();
            buttonItemSubtract = new Button();
            textBoxOrderAmount = new TextBox();
            radioButtonSize3 = new RadioButton();
            radioButtonSize2 = new RadioButton();
            radioButtonSize1 = new RadioButton();
            groupBoxSides = new GroupBox();
            labelSidesPrice = new Label();
            labelSidesAmount = new Label();
            buttonAddSides3 = new Button();
            buttonAddSides2 = new Button();
            buttonAddSides1 = new Button();
            buttonSubtractSides3 = new Button();
            buttonSubtractSides2 = new Button();
            buttonSubtractSides1 = new Button();
            textBoxAmountSides3 = new TextBox();
            textBoxAmountSides2 = new TextBox();
            textBoxAmountSides1 = new TextBox();
            textBoxPriceSides3 = new TextBox();
            textBoxPriceSides2 = new TextBox();
            textBoxPriceSides1 = new TextBox();
            checkBoxSides3 = new CheckBox();
            checkBoxSides1 = new CheckBox();
            checkBoxSides2 = new CheckBox();
            textBoxTotal = new TextBox();
            textBoxCash = new TextBox();
            textBoxChange = new TextBox();
            buttonOrderCompute = new Button();
            buttonPrint = new Button();
            labelOrderTotal = new Label();
            labelCash = new Label();
            labelChange = new Label();
            groupBoxPrices.SuspendLayout();
            groupBoxSize.SuspendLayout();
            groupBoxSides.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrices
            // 
            groupBoxPrices.BackColor = SystemColors.ControlDarkDark;
            groupBoxPrices.Controls.Add(textBoxItem3);
            groupBoxPrices.Controls.Add(textBoxItem2);
            groupBoxPrices.Controls.Add(textBoxItem1);
            groupBoxPrices.Controls.Add(labelItem3);
            groupBoxPrices.Controls.Add(labelItem2);
            groupBoxPrices.Controls.Add(labelItem1);
            groupBoxPrices.Location = new Point(12, 12);
            groupBoxPrices.Margin = new Padding(5);
            groupBoxPrices.Name = "groupBoxPrices";
            groupBoxPrices.Size = new Size(183, 244);
            groupBoxPrices.TabIndex = 0;
            groupBoxPrices.TabStop = false;
            groupBoxPrices.Text = "Price List";
            // 
            // textBoxItem3
            // 
            textBoxItem3.Location = new Point(106, 142);
            textBoxItem3.Name = "textBoxItem3";
            textBoxItem3.Size = new Size(64, 23);
            textBoxItem3.TabIndex = 8;
            textBoxItem3.Text = "300";
            textBoxItem3.TextAlign = HorizontalAlignment.Center;
            textBoxItem3.KeyPress += filterNumerics;
            // 
            // textBoxItem2
            // 
            textBoxItem2.Location = new Point(106, 102);
            textBoxItem2.Name = "textBoxItem2";
            textBoxItem2.Size = new Size(64, 23);
            textBoxItem2.TabIndex = 7;
            textBoxItem2.Text = "200";
            textBoxItem2.TextAlign = HorizontalAlignment.Center;
            textBoxItem2.KeyPress += filterNumerics;
            // 
            // textBoxItem1
            // 
            textBoxItem1.Location = new Point(106, 62);
            textBoxItem1.Name = "textBoxItem1";
            textBoxItem1.Size = new Size(64, 23);
            textBoxItem1.TabIndex = 6;
            textBoxItem1.Text = "100";
            textBoxItem1.TextAlign = HorizontalAlignment.Center;
            textBoxItem1.KeyPress += filterNumerics;
            // 
            // labelItem3
            // 
            labelItem3.AutoSize = true;
            labelItem3.Location = new Point(18, 142);
            labelItem3.Name = "labelItem3";
            labelItem3.Size = new Size(73, 15);
            labelItem3.TabIndex = 4;
            labelItem3.Text = "Special Pizza";
            // 
            // labelItem2
            // 
            labelItem2.AutoSize = true;
            labelItem2.Location = new Point(18, 102);
            labelItem2.Name = "labelItem2";
            labelItem2.Size = new Size(77, 15);
            labelItem2.TabIndex = 3;
            labelItem2.Text = "Premier Pizza";
            // 
            // labelItem1
            // 
            labelItem1.AutoSize = true;
            labelItem1.Location = new Point(18, 62);
            labelItem1.Name = "labelItem1";
            labelItem1.Size = new Size(83, 15);
            labelItem1.TabIndex = 2;
            labelItem1.Text = "Standard Pizza";
            // 
            // groupBoxSize
            // 
            groupBoxSize.BackColor = SystemColors.ControlDarkDark;
            groupBoxSize.Controls.Add(label1);
            groupBoxSize.Controls.Add(buttonItemAdd);
            groupBoxSize.Controls.Add(buttonItemSubtract);
            groupBoxSize.Controls.Add(textBoxOrderAmount);
            groupBoxSize.Controls.Add(radioButtonSize3);
            groupBoxSize.Controls.Add(radioButtonSize2);
            groupBoxSize.Controls.Add(radioButtonSize1);
            groupBoxSize.Location = new Point(201, 12);
            groupBoxSize.Margin = new Padding(5);
            groupBoxSize.Name = "groupBoxSize";
            groupBoxSize.Size = new Size(180, 244);
            groupBoxSize.TabIndex = 1;
            groupBoxSize.TabStop = false;
            groupBoxSize.Text = "Pizza Size";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 183);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 17;
            label1.Text = "Amount";
            // 
            // buttonItemAdd
            // 
            buttonItemAdd.Location = new Point(139, 199);
            buttonItemAdd.Name = "buttonItemAdd";
            buttonItemAdd.Size = new Size(32, 24);
            buttonItemAdd.TabIndex = 16;
            buttonItemAdd.Text = "+";
            buttonItemAdd.UseVisualStyleBackColor = true;
            buttonItemAdd.Click += buttonItemAdd_Click;
            // 
            // buttonItemSubtract
            // 
            buttonItemSubtract.Enabled = false;
            buttonItemSubtract.Location = new Point(99, 199);
            buttonItemSubtract.Name = "buttonItemSubtract";
            buttonItemSubtract.Size = new Size(32, 24);
            buttonItemSubtract.TabIndex = 15;
            buttonItemSubtract.Text = "-";
            buttonItemSubtract.UseVisualStyleBackColor = true;
            buttonItemSubtract.Click += buttonItemSubtract_Click;
            // 
            // textBoxOrderAmount
            // 
            textBoxOrderAmount.Location = new Point(19, 199);
            textBoxOrderAmount.Name = "textBoxOrderAmount";
            textBoxOrderAmount.Size = new Size(64, 23);
            textBoxOrderAmount.TabIndex = 9;
            textBoxOrderAmount.Text = "1";
            textBoxOrderAmount.TextAlign = HorizontalAlignment.Center;
            textBoxOrderAmount.KeyPress += filterNumerics;
            // 
            // radioButtonSize3
            // 
            radioButtonSize3.AutoSize = true;
            radioButtonSize3.Location = new Point(19, 144);
            radioButtonSize3.Name = "radioButtonSize3";
            radioButtonSize3.Size = new Size(62, 19);
            radioButtonSize3.TabIndex = 2;
            radioButtonSize3.TabStop = true;
            radioButtonSize3.Text = "Special";
            radioButtonSize3.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize2
            // 
            radioButtonSize2.AutoSize = true;
            radioButtonSize2.Location = new Point(19, 104);
            radioButtonSize2.Name = "radioButtonSize2";
            radioButtonSize2.Size = new Size(66, 19);
            radioButtonSize2.TabIndex = 1;
            radioButtonSize2.TabStop = true;
            radioButtonSize2.Text = "Premier";
            radioButtonSize2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize1
            // 
            radioButtonSize1.AutoSize = true;
            radioButtonSize1.Checked = true;
            radioButtonSize1.Location = new Point(19, 64);
            radioButtonSize1.Name = "radioButtonSize1";
            radioButtonSize1.Size = new Size(72, 19);
            radioButtonSize1.TabIndex = 0;
            radioButtonSize1.TabStop = true;
            radioButtonSize1.Text = "Standard";
            radioButtonSize1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSides
            // 
            groupBoxSides.BackColor = SystemColors.ControlDarkDark;
            groupBoxSides.Controls.Add(labelSidesPrice);
            groupBoxSides.Controls.Add(labelSidesAmount);
            groupBoxSides.Controls.Add(buttonAddSides3);
            groupBoxSides.Controls.Add(buttonAddSides2);
            groupBoxSides.Controls.Add(buttonAddSides1);
            groupBoxSides.Controls.Add(buttonSubtractSides3);
            groupBoxSides.Controls.Add(buttonSubtractSides2);
            groupBoxSides.Controls.Add(buttonSubtractSides1);
            groupBoxSides.Controls.Add(textBoxAmountSides3);
            groupBoxSides.Controls.Add(textBoxAmountSides2);
            groupBoxSides.Controls.Add(textBoxAmountSides1);
            groupBoxSides.Controls.Add(textBoxPriceSides3);
            groupBoxSides.Controls.Add(textBoxPriceSides2);
            groupBoxSides.Controls.Add(textBoxPriceSides1);
            groupBoxSides.Controls.Add(checkBoxSides3);
            groupBoxSides.Controls.Add(checkBoxSides1);
            groupBoxSides.Controls.Add(checkBoxSides2);
            groupBoxSides.Location = new Point(387, 12);
            groupBoxSides.Margin = new Padding(5);
            groupBoxSides.Name = "groupBoxSides";
            groupBoxSides.Size = new Size(305, 244);
            groupBoxSides.TabIndex = 1;
            groupBoxSides.TabStop = false;
            groupBoxSides.Text = "Add-Ons";
            // 
            // labelSidesPrice
            // 
            labelSidesPrice.AutoSize = true;
            labelSidesPrice.Location = new Point(123, 53);
            labelSidesPrice.Name = "labelSidesPrice";
            labelSidesPrice.Size = new Size(33, 15);
            labelSidesPrice.TabIndex = 16;
            labelSidesPrice.Text = "Price";
            // 
            // labelSidesAmount
            // 
            labelSidesAmount.AutoSize = true;
            labelSidesAmount.Location = new Point(163, 53);
            labelSidesAmount.Name = "labelSidesAmount";
            labelSidesAmount.Size = new Size(51, 15);
            labelSidesAmount.TabIndex = 15;
            labelSidesAmount.Text = "Amount";
            // 
            // buttonAddSides3
            // 
            buttonAddSides3.Location = new Point(259, 149);
            buttonAddSides3.Name = "buttonAddSides3";
            buttonAddSides3.Size = new Size(32, 24);
            buttonAddSides3.TabIndex = 14;
            buttonAddSides3.Text = "+";
            buttonAddSides3.UseVisualStyleBackColor = true;
            buttonAddSides3.Click += AddSidesAmount;
            // 
            // buttonAddSides2
            // 
            buttonAddSides2.Location = new Point(259, 109);
            buttonAddSides2.Name = "buttonAddSides2";
            buttonAddSides2.Size = new Size(32, 24);
            buttonAddSides2.TabIndex = 13;
            buttonAddSides2.Text = "+";
            buttonAddSides2.UseVisualStyleBackColor = true;
            buttonAddSides2.Click += AddSidesAmount;
            // 
            // buttonAddSides1
            // 
            buttonAddSides1.Location = new Point(259, 77);
            buttonAddSides1.Name = "buttonAddSides1";
            buttonAddSides1.Size = new Size(32, 24);
            buttonAddSides1.TabIndex = 12;
            buttonAddSides1.Text = "+";
            buttonAddSides1.UseVisualStyleBackColor = true;
            buttonAddSides1.Click += AddSidesAmount;
            // 
            // buttonSubtractSides3
            // 
            buttonSubtractSides3.Enabled = false;
            buttonSubtractSides3.Location = new Point(219, 149);
            buttonSubtractSides3.Name = "buttonSubtractSides3";
            buttonSubtractSides3.Size = new Size(32, 24);
            buttonSubtractSides3.TabIndex = 11;
            buttonSubtractSides3.Text = "-";
            buttonSubtractSides3.UseVisualStyleBackColor = true;
            buttonSubtractSides3.Click += SubtractSidesAmount;
            // 
            // buttonSubtractSides2
            // 
            buttonSubtractSides2.Enabled = false;
            buttonSubtractSides2.Location = new Point(219, 109);
            buttonSubtractSides2.Name = "buttonSubtractSides2";
            buttonSubtractSides2.Size = new Size(32, 24);
            buttonSubtractSides2.TabIndex = 10;
            buttonSubtractSides2.Text = "-";
            buttonSubtractSides2.UseVisualStyleBackColor = true;
            buttonSubtractSides2.Click += SubtractSidesAmount;
            // 
            // buttonSubtractSides1
            // 
            buttonSubtractSides1.Enabled = false;
            buttonSubtractSides1.Location = new Point(219, 77);
            buttonSubtractSides1.Name = "buttonSubtractSides1";
            buttonSubtractSides1.Size = new Size(32, 24);
            buttonSubtractSides1.TabIndex = 9;
            buttonSubtractSides1.Text = "-";
            buttonSubtractSides1.UseVisualStyleBackColor = true;
            buttonSubtractSides1.Click += SubtractSidesAmount;
            // 
            // textBoxAmountSides3
            // 
            textBoxAmountSides3.Location = new Point(171, 149);
            textBoxAmountSides3.Name = "textBoxAmountSides3";
            textBoxAmountSides3.Size = new Size(40, 23);
            textBoxAmountSides3.TabIndex = 8;
            textBoxAmountSides3.Text = "0";
            textBoxAmountSides3.TextAlign = HorizontalAlignment.Center;
            textBoxAmountSides3.KeyPress += filterNumerics;
            // 
            // textBoxAmountSides2
            // 
            textBoxAmountSides2.Location = new Point(171, 109);
            textBoxAmountSides2.Name = "textBoxAmountSides2";
            textBoxAmountSides2.Size = new Size(40, 23);
            textBoxAmountSides2.TabIndex = 7;
            textBoxAmountSides2.Text = "0";
            textBoxAmountSides2.TextAlign = HorizontalAlignment.Center;
            textBoxAmountSides2.KeyPress += filterNumerics;
            // 
            // textBoxAmountSides1
            // 
            textBoxAmountSides1.Location = new Point(171, 77);
            textBoxAmountSides1.Name = "textBoxAmountSides1";
            textBoxAmountSides1.Size = new Size(40, 23);
            textBoxAmountSides1.TabIndex = 6;
            textBoxAmountSides1.Text = "0";
            textBoxAmountSides1.TextAlign = HorizontalAlignment.Center;
            textBoxAmountSides1.KeyPress += filterNumerics;
            // 
            // textBoxPriceSides3
            // 
            textBoxPriceSides3.Location = new Point(123, 149);
            textBoxPriceSides3.Name = "textBoxPriceSides3";
            textBoxPriceSides3.Size = new Size(40, 23);
            textBoxPriceSides3.TabIndex = 5;
            textBoxPriceSides3.Text = "80";
            textBoxPriceSides3.TextAlign = HorizontalAlignment.Center;
            textBoxPriceSides3.KeyPress += filterNumerics;
            // 
            // textBoxPriceSides2
            // 
            textBoxPriceSides2.Location = new Point(123, 109);
            textBoxPriceSides2.Name = "textBoxPriceSides2";
            textBoxPriceSides2.Size = new Size(40, 23);
            textBoxPriceSides2.TabIndex = 4;
            textBoxPriceSides2.Text = "30";
            textBoxPriceSides2.TextAlign = HorizontalAlignment.Center;
            textBoxPriceSides2.KeyPress += filterNumerics;
            // 
            // textBoxPriceSides1
            // 
            textBoxPriceSides1.Location = new Point(123, 77);
            textBoxPriceSides1.Name = "textBoxPriceSides1";
            textBoxPriceSides1.Size = new Size(40, 23);
            textBoxPriceSides1.TabIndex = 3;
            textBoxPriceSides1.Text = "50";
            textBoxPriceSides1.TextAlign = HorizontalAlignment.Center;
            textBoxPriceSides1.KeyPress += filterNumerics;
            // 
            // checkBoxSides3
            // 
            checkBoxSides3.AutoSize = true;
            checkBoxSides3.Location = new Point(27, 157);
            checkBoxSides3.Name = "checkBoxSides3";
            checkBoxSides3.Size = new Size(76, 19);
            checkBoxSides3.TabIndex = 2;
            checkBoxSides3.Text = "Spaghetti";
            checkBoxSides3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSides1
            // 
            checkBoxSides1.AutoSize = true;
            checkBoxSides1.Location = new Point(27, 77);
            checkBoxSides1.Name = "checkBoxSides1";
            checkBoxSides1.Size = new Size(50, 19);
            checkBoxSides1.TabIndex = 0;
            checkBoxSides1.Text = "Fries";
            checkBoxSides1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSides2
            // 
            checkBoxSides2.AutoSize = true;
            checkBoxSides2.Location = new Point(27, 117);
            checkBoxSides2.Name = "checkBoxSides2";
            checkBoxSides2.Size = new Size(68, 19);
            checkBoxSides2.TabIndex = 1;
            checkBoxSides2.Text = "Iced Tea";
            checkBoxSides2.UseVisualStyleBackColor = true;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Enabled = false;
            textBoxTotal.Location = new Point(510, 262);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(128, 23);
            textBoxTotal.TabIndex = 10;
            textBoxTotal.Text = "0";
            textBoxTotal.TextAlign = HorizontalAlignment.Center;
            textBoxTotal.KeyPress += filterNumerics;
            // 
            // textBoxCash
            // 
            textBoxCash.Location = new Point(510, 291);
            textBoxCash.Name = "textBoxCash";
            textBoxCash.Size = new Size(128, 23);
            textBoxCash.TabIndex = 11;
            textBoxCash.Text = "0";
            textBoxCash.TextAlign = HorizontalAlignment.Center;
            textBoxCash.KeyPress += filterNumerics;
            // 
            // textBoxChange
            // 
            textBoxChange.Enabled = false;
            textBoxChange.Location = new Point(510, 320);
            textBoxChange.Name = "textBoxChange";
            textBoxChange.Size = new Size(128, 23);
            textBoxChange.TabIndex = 12;
            textBoxChange.Text = "0";
            textBoxChange.TextAlign = HorizontalAlignment.Center;
            textBoxChange.KeyPress += filterNumerics;
            // 
            // buttonOrderCompute
            // 
            buttonOrderCompute.Location = new Point(562, 349);
            buttonOrderCompute.Name = "buttonOrderCompute";
            buttonOrderCompute.Size = new Size(76, 24);
            buttonOrderCompute.TabIndex = 16;
            buttonOrderCompute.Text = "Compute";
            buttonOrderCompute.UseVisualStyleBackColor = true;
            buttonOrderCompute.Click += computeFunc;
            // 
            // buttonPrint
            // 
            buttonPrint.Enabled = false;
            buttonPrint.Location = new Point(480, 349);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(76, 24);
            buttonPrint.TabIndex = 15;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            // 
            // labelOrderTotal
            // 
            labelOrderTotal.AutoSize = true;
            labelOrderTotal.Location = new Point(426, 270);
            labelOrderTotal.Name = "labelOrderTotal";
            labelOrderTotal.Size = new Size(32, 15);
            labelOrderTotal.TabIndex = 17;
            labelOrderTotal.Text = "Total";
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Location = new Point(426, 299);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(33, 15);
            labelCash.TabIndex = 18;
            labelCash.Text = "Cash";
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Location = new Point(426, 328);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(48, 15);
            labelChange.TabIndex = 19;
            labelChange.Text = "Change";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(702, 386);
            Controls.Add(labelChange);
            Controls.Add(labelCash);
            Controls.Add(labelOrderTotal);
            Controls.Add(buttonOrderCompute);
            Controls.Add(buttonPrint);
            Controls.Add(textBoxChange);
            Controls.Add(textBoxCash);
            Controls.Add(textBoxTotal);
            Controls.Add(groupBoxSize);
            Controls.Add(groupBoxSides);
            Controls.Add(groupBoxPrices);
            Name = "MainForm";
            Text = "Order";
            groupBoxPrices.ResumeLayout(false);
            groupBoxPrices.PerformLayout();
            groupBoxSize.ResumeLayout(false);
            groupBoxSize.PerformLayout();
            groupBoxSides.ResumeLayout(false);
            groupBoxSides.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPrices;
        private Label labelItem3;
        private Label labelItem2;
        private Label labelItem1;
        private GroupBox groupBoxSize;
        private RadioButton radioButtonSize3;
        private RadioButton radioButtonSize2;
        private RadioButton radioButtonSize1;
        private GroupBox groupBoxSides;
        private CheckBox checkBoxSides3;
        private CheckBox checkBoxSides1;
        private CheckBox checkBoxSides2;
        private Button buttonAddSides3;
        private Button buttonAddSides2;
        private Button buttonAddSides1;
        private Button buttonSubtractSides3;
        private Button buttonSubtractSides2;
        private Button buttonSubtractSides1;
        private TextBox textBoxAmountSides3;
        private TextBox textBoxAmountSides2;
        private TextBox textBoxAmountSides1;
        private TextBox textBoxPriceSides3;
        private TextBox textBoxPriceSides2;
        private TextBox textBoxPriceSides1;
        private Label labelSidesPrice;
        private Label labelSidesAmount;
        private TextBox textBoxItem3;
        private TextBox textBoxItem2;
        private TextBox textBoxItem1;
        private Label label1;
        private Button buttonItemAdd;
        private Button buttonItemSubtract;
        private TextBox textBoxOrderAmount;
        private TextBox textBoxTotal;
        private TextBox textBoxCash;
        private TextBox textBoxChange;
        private Button buttonOrderCompute;
        private Button buttonPrint;
        private Label labelOrderTotal;
        private Label labelCash;
        private Label labelChange;
    }
}