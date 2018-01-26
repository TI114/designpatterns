namespace Observer_Pattern_Example
{
    partial class Window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add_observer = new System.Windows.Forms.Button();
            this.btn_remove_observer = new System.Windows.Forms.Button();
            this.btn_notify_observer = new System.Windows.Forms.Button();
            this.listBox_Observer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_add_observer
            // 
            this.btn_add_observer.Location = new System.Drawing.Point(12, 12);
            this.btn_add_observer.Name = "btn_add_observer";
            this.btn_add_observer.Size = new System.Drawing.Size(132, 23);
            this.btn_add_observer.TabIndex = 0;
            this.btn_add_observer.Text = "add Observer";
            this.btn_add_observer.UseVisualStyleBackColor = true;
            this.btn_add_observer.Click += new System.EventHandler(this.btn_add_observer_Click);
            // 
            // btn_remove_observer
            // 
            this.btn_remove_observer.Location = new System.Drawing.Point(12, 57);
            this.btn_remove_observer.Name = "btn_remove_observer";
            this.btn_remove_observer.Size = new System.Drawing.Size(132, 23);
            this.btn_remove_observer.TabIndex = 1;
            this.btn_remove_observer.Text = "remove Observer";
            this.btn_remove_observer.UseVisualStyleBackColor = true;
            this.btn_remove_observer.Click += new System.EventHandler(this.btn_remove_observer_Click);
            // 
            // btn_notify_observer
            // 
            this.btn_notify_observer.Location = new System.Drawing.Point(12, 108);
            this.btn_notify_observer.Name = "btn_notify_observer";
            this.btn_notify_observer.Size = new System.Drawing.Size(132, 23);
            this.btn_notify_observer.TabIndex = 2;
            this.btn_notify_observer.Text = "notify Observer";
            this.btn_notify_observer.UseVisualStyleBackColor = true;
            this.btn_notify_observer.Click += new System.EventHandler(this.btn_notify_observer_Click);
            // 
            // listBox_Observer
            // 
            this.listBox_Observer.FormattingEnabled = true;
            this.listBox_Observer.Location = new System.Drawing.Point(165, 13);
            this.listBox_Observer.Name = "listBox_Observer";
            this.listBox_Observer.Size = new System.Drawing.Size(224, 355);
            this.listBox_Observer.TabIndex = 3;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 406);
            this.Controls.Add(this.listBox_Observer);
            this.Controls.Add(this.btn_notify_observer);
            this.Controls.Add(this.btn_remove_observer);
            this.Controls.Add(this.btn_add_observer);
            this.Name = "Window";
            this.Text = "Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_observer;
        private System.Windows.Forms.Button btn_remove_observer;
        private System.Windows.Forms.Button btn_notify_observer;
        private System.Windows.Forms.ListBox listBox_Observer;
    }
}

