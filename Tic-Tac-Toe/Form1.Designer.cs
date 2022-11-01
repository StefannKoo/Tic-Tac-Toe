namespace IKS_OKS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPrviIgrac = new System.Windows.Forms.TextBox();
            this.txtbDrugiIgrac = new System.Windows.Forms.TextBox();
            this.btnLogovanje = new System.Windows.Forms.Button();
            this.tmrProvjeriPolja = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvi igrac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugi igrac";
            // 
            // txtbPrviIgrac
            // 
            this.txtbPrviIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrviIgrac.Location = new System.Drawing.Point(159, 46);
            this.txtbPrviIgrac.Name = "txtbPrviIgrac";
            this.txtbPrviIgrac.Size = new System.Drawing.Size(143, 26);
            this.txtbPrviIgrac.TabIndex = 2;
            // 
            // txtbDrugiIgrac
            // 
            this.txtbDrugiIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDrugiIgrac.Location = new System.Drawing.Point(159, 112);
            this.txtbDrugiIgrac.Name = "txtbDrugiIgrac";
            this.txtbDrugiIgrac.Size = new System.Drawing.Size(143, 26);
            this.txtbDrugiIgrac.TabIndex = 3;
            // 
            // btnLogovanje
            // 
            this.btnLogovanje.Location = new System.Drawing.Point(192, 153);
            this.btnLogovanje.Name = "btnLogovanje";
            this.btnLogovanje.Size = new System.Drawing.Size(110, 43);
            this.btnLogovanje.TabIndex = 4;
            this.btnLogovanje.Text = "Uloguj se";
            this.btnLogovanje.UseVisualStyleBackColor = true;
            this.btnLogovanje.Click += new System.EventHandler(this.btnLogovanje_Click);
            // 
            // tmrProvjeriPolja
            // 
            this.tmrProvjeriPolja.Enabled = true;
            this.tmrProvjeriPolja.Tick += new System.EventHandler(this.tmrProvjeriPolja_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 207);
            this.Controls.Add(this.btnLogovanje);
            this.Controls.Add(this.txtbDrugiIgrac);
            this.Controls.Add(this.txtbPrviIgrac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 245);
            this.MinimumSize = new System.Drawing.Size(330, 245);
            this.Name = "Form1";
            this.Text = "Logovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPrviIgrac;
        private System.Windows.Forms.TextBox txtbDrugiIgrac;
        private System.Windows.Forms.Button btnLogovanje;
        private System.Windows.Forms.Timer tmrProvjeriPolja;


    }
}

