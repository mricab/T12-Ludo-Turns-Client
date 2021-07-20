
namespace LudoClient
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.CloseGameButton = new System.Windows.Forms.Button();
            this.BoardPictureBox = new System.Windows.Forms.PictureBox();
            this.BlocksImageList = new System.Windows.Forms.ImageList(this.components);
            this.TurnLabel = new System.Windows.Forms.Label();
            this.EndTurnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseGameButton
            // 
            this.CloseGameButton.Location = new System.Drawing.Point(713, 12);
            this.CloseGameButton.Name = "CloseGameButton";
            this.CloseGameButton.Size = new System.Drawing.Size(75, 23);
            this.CloseGameButton.TabIndex = 0;
            this.CloseGameButton.Text = "Cerrar";
            this.CloseGameButton.UseVisualStyleBackColor = true;
            this.CloseGameButton.Click += new System.EventHandler(this.CloseGameButton_Click);
            // 
            // BoardPictureBox
            // 
            this.BoardPictureBox.Location = new System.Drawing.Point(98, 18);
            this.BoardPictureBox.Name = "BoardPictureBox";
            this.BoardPictureBox.Size = new System.Drawing.Size(420, 420);
            this.BoardPictureBox.TabIndex = 1;
            this.BoardPictureBox.TabStop = false;
            // 
            // BlocksImageList
            // 
            this.BlocksImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BlocksImageList.ImageStream")));
            this.BlocksImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.BlocksImageList.Images.SetKeyName(0, "block1.png");
            this.BlocksImageList.Images.SetKeyName(1, "block2.png");
            this.BlocksImageList.Images.SetKeyName(2, "block3.png");
            this.BlocksImageList.Images.SetKeyName(3, "block4.png");
            this.BlocksImageList.Images.SetKeyName(4, "block5.png");
            this.BlocksImageList.Images.SetKeyName(5, "block6.png");
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Location = new System.Drawing.Point(640, 129);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(58, 13);
            this.TurnLabel.TabIndex = 2;
            this.TurnLabel.Text = "Esperando";
            this.TurnLabel.Visible = false;
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Location = new System.Drawing.Point(633, 162);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(75, 23);
            this.EndTurnButton.TabIndex = 3;
            this.EndTurnButton.Text = "Terminar";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Visible = false;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.BoardPictureBox);
            this.Controls.Add(this.CloseGameButton);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseGameButton;
        private System.Windows.Forms.PictureBox BoardPictureBox;
        private System.Windows.Forms.ImageList BlocksImageList;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button EndTurnButton;
    }
}