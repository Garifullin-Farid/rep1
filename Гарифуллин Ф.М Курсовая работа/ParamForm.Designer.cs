namespace Гарифуллин_Ф.М_Курсовая_работа
{
    partial class ParamForm
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
            textBox1 = new TextBox();
            buttonSetParam = new Button();
            textBox2 = new TextBox();
            ButtonAdd = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonSetParam
            // 
            buttonSetParam.Location = new Point(407, 60);
            buttonSetParam.Name = "buttonSetParam";
            buttonSetParam.Size = new Size(75, 23);
            buttonSetParam.TabIndex = 1;
            buttonSetParam.Text = "button1";
            buttonSetParam.UseVisualStyleBackColor = true;
            buttonSetParam.Click += buttonSetParam_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(335, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(42, 23);
            textBox2.TabIndex = 2;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(205, 198);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(228, 23);
            ButtonAdd.TabIndex = 3;
            ButtonAdd.Text = "button1";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ParamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 303);
            Controls.Add(ButtonAdd);
            Controls.Add(textBox2);
            Controls.Add(buttonSetParam);
            Controls.Add(textBox1);
            Name = "ParamForm";
            Text = "ParamForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonSetParam;
        private TextBox textBox2;
        private Button ButtonAdd;
    }
}