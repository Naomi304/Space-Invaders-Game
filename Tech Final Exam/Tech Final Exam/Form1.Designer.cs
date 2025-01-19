
namespace Exam
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
            this.movetimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.canon = new System.Windows.Forms.PictureBox();
            this.laser = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // movetimer
            // 
            this.movetimer.Enabled = true;
            this.movetimer.Tick += new System.EventHandler(this.movetimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(15, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pointsLabel.Location = new System.Drawing.Point(114, 395);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(29, 31);
            this.pointsLabel.TabIndex = 6;
            this.pointsLabel.Text = "0";
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::Tech_Final_Exam.Properties.Resources.fall_meteorite_stock_photography_meteoroid_royaltyfree_drawing_meteorite_fall_dinosaur_png_clipart_removebg_preview__3_;
            this.obstacle1.Location = new System.Drawing.Point(950, 61);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(84, 84);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstacle1.TabIndex = 4;
            this.obstacle1.TabStop = false;
            this.obstacle1.VisibleChanged += new System.EventHandler(this.movetimer_Tick);
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::Tech_Final_Exam.Properties.Resources.llll_removebg_preview__1_;
            this.obstacle2.Location = new System.Drawing.Point(-106, 134);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(112, 104);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            // 
            // canon
            // 
            this.canon.Image = global::Tech_Final_Exam.Properties.Resources.LaserCannon_removebg_preview;
            this.canon.Location = new System.Drawing.Point(346, 379);
            this.canon.Name = "canon";
            this.canon.Size = new System.Drawing.Size(161, 90);
            this.canon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canon.TabIndex = 2;
            this.canon.TabStop = false;
            // 
            // laser
            // 
            this.laser.Image = global::Tech_Final_Exam.Properties.Resources.jkk_removebg_preview;
            this.laser.Location = new System.Drawing.Point(373, 329);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(100, 50);
            this.laser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.laser.TabIndex = 1;
            this.laser.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Tech_Final_Exam.Properties.Resources.ufo1;
            this.ufo.Location = new System.Drawing.Point(0, 0);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(100, 50);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ufo.TabIndex = 0;
            this.ufo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.canon);
            this.Controls.Add(this.laser);
            this.Controls.Add(this.ufo);
            this.Name = "Form1";
            this.Text = "Attaque l\'ufo!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.PictureBox laser;
        private System.Windows.Forms.PictureBox canon;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.Timer movetimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pointsLabel;
    }
}

