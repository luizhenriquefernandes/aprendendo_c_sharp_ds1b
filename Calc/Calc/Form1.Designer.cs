namespace Calc
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 31);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ravie", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 31);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 1;
            label2.Text = "Número 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ravie", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 143);
            label3.Name = "label3";
            label3.Size = new Size(27, 30);
            label3.TabIndex = 2;
            label3.Text = "+";
            // 
            // txtNum1
            // 
            txtNum1.BackColor = Color.Linen;
            txtNum1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(121, 142);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 35);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = Color.Linen;
            txtNum2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(400, 143);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 35);
            txtNum2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Ravie", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(238, 216);
            button1.Name = "button1";
            button1.Size = new Size(181, 69);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += button1_MouseClick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 339);
            Controls.Add(button1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button button1;
    }
}
