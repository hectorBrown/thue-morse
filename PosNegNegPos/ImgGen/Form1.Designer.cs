namespace ImgGen
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
            this.PB_main = new System.Windows.Forms.PictureBox();
            this.TIM_init = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_main
            // 
            this.PB_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_main.Location = new System.Drawing.Point(0, 0);
            this.PB_main.Name = "PB_main";
            this.PB_main.Size = new System.Drawing.Size(1206, 627);
            this.PB_main.TabIndex = 0;
            this.PB_main.TabStop = false;
            // 
            // TIM_init
            // 
            this.TIM_init.Enabled = true;
            this.TIM_init.Interval = 2000;
            this.TIM_init.Tick += new System.EventHandler(this.TIM_init_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 627);
            this.Controls.Add(this.PB_main);
            this.Name = "Form1";
            this.Text = "1001";
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_main;
        private System.Windows.Forms.Timer TIM_init;
    }
}

