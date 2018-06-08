namespace SnakeGame
{
    partial class frmSnake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.picGameBoard = new System.Windows.Forms.PictureBox();
            this.scrLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picGameBoard
            // 
            this.picGameBoard.Location = new System.Drawing.Point(50, 30);
            this.picGameBoard.Name = "picGameBoard";
            this.picGameBoard.Size = new System.Drawing.Size(420, 420);
            this.picGameBoard.TabIndex = 0;
            this.picGameBoard.TabStop = false;
            // 
            // scrLabel
            // 
            this.scrLabel.AutoSize = true;
            this.scrLabel.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrLabel.Location = new System.Drawing.Point(45, 464);
            this.scrLabel.Name = "scrLabel";
            this.scrLabel.Size = new System.Drawing.Size(71, 30);
            this.scrLabel.TabIndex = 1;
            this.scrLabel.Text = "Score:";
            this.scrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "bonus1.png");
            this.imgList.Images.SetKeyName(1, "bonus2.png");
            this.imgList.Images.SetKeyName(2, "bonus3.png");
            this.imgList.Images.SetKeyName(3, "bonus4.png");
            this.imgList.Images.SetKeyName(4, "snake_body.png");
            this.imgList.Images.SetKeyName(5, "snake_head.png");
            this.imgList.Images.SetKeyName(6, "wall.png");
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 517);
            this.Controls.Add(this.scrLabel);
            this.Controls.Add(this.picGameBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSnake";
            this.Text = "SNAKE ";
            this.Load += new System.EventHandler(this.frmSnake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGameBoard;
        private System.Windows.Forms.Label scrLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imgList;
    }
}

