namespace Are_u_dumb_
{
    partial class areudumb
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(areudumb));
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.lblareudumb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnno
            // 
            this.btnno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnno.AutoSize = true;
            this.btnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnno.Location = new System.Drawing.Point(370, 334);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(100, 100);
            this.btnno.TabIndex = 0;
            this.btnno.Text = "NO";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnyes.AutoSize = true;
            this.btnyes.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyes.Location = new System.Drawing.Point(12, 334);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(100, 100);
            this.btnyes.TabIndex = 1;
            this.btnyes.Text = "YES";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // lblareudumb
            // 
            this.lblareudumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblareudumb.AutoSize = true;
            this.lblareudumb.Font = new System.Drawing.Font("Yu Gothic UI", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblareudumb.Location = new System.Drawing.Point(73, 178);
            this.lblareudumb.Name = "lblareudumb";
            this.lblareudumb.Size = new System.Drawing.Size(332, 71);
            this.lblareudumb.TabIndex = 3;
            this.lblareudumb.Text = "Are u dumb?";
            // 
            // areudumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.lblareudumb);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.btnno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "areudumb";
            this.Text = "Are u dumb?";
            this.Load += new System.EventHandler(this.areudumb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label lblareudumb;
    }
}

