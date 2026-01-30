namespace Calculadora
{
    partial class frmCalculadora
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
            txtVariableA = new Label();
            txtVariableB = new Label();
            textBoxVariableA = new TextBox();
            txtBoxVariableB = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtVariableA
            // 
            txtVariableA.AutoSize = true;
            txtVariableA.Location = new Point(37, 27);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(77, 20);
            txtVariableA.TabIndex = 0;
            txtVariableA.Text = "Variable A";
            txtVariableA.Click += label1_Click;
            // 
            // txtVariableB
            // 
            txtVariableB.AutoSize = true;
            txtVariableB.Location = new Point(38, 157);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(76, 20);
            txtVariableB.TabIndex = 1;
            txtVariableB.Text = "Variable B";
            // 
            // textBoxVariableA
            // 
            textBoxVariableA.Location = new Point(39, 75);
            textBoxVariableA.Name = "textBoxVariableA";
            textBoxVariableA.Size = new Size(125, 27);
            textBoxVariableA.TabIndex = 2;
            // 
            // txtBoxVariableB
            // 
            txtBoxVariableB.Location = new Point(42, 216);
            txtBoxVariableB.Name = "txtBoxVariableB";
            txtBoxVariableB.Size = new Size(125, 27);
            txtBoxVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(275, 136);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 291);
            Controls.Add(btnCalcular);
            Controls.Add(txtBoxVariableB);
            Controls.Add(textBoxVariableA);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Name = "frmCalculadora";
            Text = "frmCalculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtVariableA;
        private Label txtVariableB;
        private TextBox textBoxVariableA;
        private TextBox txtBoxVariableB;
        private Button btnCalcular;
    }
}