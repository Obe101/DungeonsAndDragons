namespace DungeonsAndDragons
{
    partial class MainFrm
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
            this.NewCharBtn = new System.Windows.Forms.Button();
            this.UpdateCharBtn = new System.Windows.Forms.Button();
            this.DeleteCharBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewCharBtn
            // 
            this.NewCharBtn.Location = new System.Drawing.Point(55, 199);
            this.NewCharBtn.Name = "NewCharBtn";
            this.NewCharBtn.Size = new System.Drawing.Size(165, 63);
            this.NewCharBtn.TabIndex = 0;
            this.NewCharBtn.Text = "New Character";
            this.NewCharBtn.UseVisualStyleBackColor = true;
            this.NewCharBtn.Click += new System.EventHandler(this.NewCharBtn_Click);
            // 
            // UpdateCharBtn
            // 
            this.UpdateCharBtn.Location = new System.Drawing.Point(294, 198);
            this.UpdateCharBtn.Name = "UpdateCharBtn";
            this.UpdateCharBtn.Size = new System.Drawing.Size(179, 64);
            this.UpdateCharBtn.TabIndex = 1;
            this.UpdateCharBtn.Text = "Update Character";
            this.UpdateCharBtn.UseVisualStyleBackColor = true;
            this.UpdateCharBtn.Click += new System.EventHandler(this.UpdateCharBtn_Click);
            // 
            // DeleteCharBtn
            // 
            this.DeleteCharBtn.Location = new System.Drawing.Point(531, 199);
            this.DeleteCharBtn.Name = "DeleteCharBtn";
            this.DeleteCharBtn.Size = new System.Drawing.Size(172, 63);
            this.DeleteCharBtn.TabIndex = 2;
            this.DeleteCharBtn.Text = "Delete Character";
            this.DeleteCharBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dungeons and Dragons DataBase";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteCharBtn);
            this.Controls.Add(this.UpdateCharBtn);
            this.Controls.Add(this.NewCharBtn);
            this.Name = "MainFrm";
            this.Text = "Main Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewCharBtn;
        private System.Windows.Forms.Button UpdateCharBtn;
        private System.Windows.Forms.Button DeleteCharBtn;
        private System.Windows.Forms.Label label1;
    }
}

