namespace Ejercicio_23_Tema_3
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
            this.pesosBtn = new System.Windows.Forms.Button();
            this.cuantosAlumnosLabel = new System.Windows.Forms.Label();
            this.porcentajeLabel = new System.Windows.Forms.Label();
            this.pesoMedioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pesosBtn
            // 
            this.pesosBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.pesosBtn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pesosBtn.Location = new System.Drawing.Point(91, 159);
            this.pesosBtn.Name = "pesosBtn";
            this.pesosBtn.Size = new System.Drawing.Size(179, 83);
            this.pesosBtn.TabIndex = 0;
            this.pesosBtn.Text = "Introducir pesos";
            this.pesosBtn.UseVisualStyleBackColor = false;
            this.pesosBtn.Click += new System.EventHandler(this.pesosBtn_Click);
            // 
            // cuantosAlumnosLabel
            // 
            this.cuantosAlumnosLabel.AutoSize = true;
            this.cuantosAlumnosLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cuantosAlumnosLabel.Location = new System.Drawing.Point(347, 57);
            this.cuantosAlumnosLabel.Name = "cuantosAlumnosLabel";
            this.cuantosAlumnosLabel.Size = new System.Drawing.Size(0, 21);
            this.cuantosAlumnosLabel.TabIndex = 1;
            // 
            // porcentajeLabel
            // 
            this.porcentajeLabel.AutoSize = true;
            this.porcentajeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.porcentajeLabel.Location = new System.Drawing.Point(347, 202);
            this.porcentajeLabel.Name = "porcentajeLabel";
            this.porcentajeLabel.Size = new System.Drawing.Size(0, 21);
            this.porcentajeLabel.TabIndex = 2;
            // 
            // pesoMedioLabel
            // 
            this.pesoMedioLabel.AutoSize = true;
            this.pesoMedioLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesoMedioLabel.Location = new System.Drawing.Point(347, 346);
            this.pesoMedioLabel.Name = "pesoMedioLabel";
            this.pesoMedioLabel.Size = new System.Drawing.Size(0, 21);
            this.pesoMedioLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1258, 544);
            this.Controls.Add(this.pesoMedioLabel);
            this.Controls.Add(this.porcentajeLabel);
            this.Controls.Add(this.cuantosAlumnosLabel);
            this.Controls.Add(this.pesosBtn);
            this.Name = "Form1";
            this.Text = "Ejercicio 23 Tema 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button pesosBtn;
        private Label cuantosAlumnosLabel;
        private Label porcentajeLabel;
        private Label pesoMedioLabel;
    }
}