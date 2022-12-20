namespace battlesim
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
            this.playericon1 = new System.Windows.Forms.PictureBox();
            this.playericon2 = new System.Windows.Forms.PictureBox();
            this.attack2 = new System.Windows.Forms.Button();
            this.attack1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.potionicon = new System.Windows.Forms.PictureBox();
            this.potions = new System.Windows.Forms.Label();
            this.heal1 = new System.Windows.Forms.Button();
            this.heal2 = new System.Windows.Forms.Button();
            this.potions2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.special1 = new System.Windows.Forms.Button();
            this.special2 = new System.Windows.Forms.Button();
            this.specialattack = new System.Windows.Forms.Label();
            this.specialattack2 = new System.Windows.Forms.Label();
            this.rounds = new System.Windows.Forms.Label();
            this.playerturn1 = new System.Windows.Forms.Label();
            this.playerturn2 = new System.Windows.Forms.Label();
            this.specialicon1 = new System.Windows.Forms.PictureBox();
            this.specialicon2 = new System.Windows.Forms.PictureBox();
            this.explore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playericon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playericon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialicon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialicon2)).BeginInit();
            this.SuspendLayout();
            // 
            // playericon1
            // 
            this.playericon1.Location = new System.Drawing.Point(114, 43);
            this.playericon1.Name = "playericon1";
            this.playericon1.Size = new System.Drawing.Size(284, 349);
            this.playericon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playericon1.TabIndex = 0;
            this.playericon1.TabStop = false;
            // 
            // playericon2
            // 
            this.playericon2.Image = global::battlesim.Properties.Resources.nameless_king;
            this.playericon2.Location = new System.Drawing.Point(495, 43);
            this.playericon2.Name = "playericon2";
            this.playericon2.Size = new System.Drawing.Size(278, 349);
            this.playericon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playericon2.TabIndex = 1;
            this.playericon2.TabStop = false;
            // 
            // attack2
            // 
            this.attack2.Location = new System.Drawing.Point(495, 398);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(278, 23);
            this.attack2.TabIndex = 2;
            this.attack2.Text = "attack";
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.Click += new System.EventHandler(this.attack2_Click);
            // 
            // attack1
            // 
            this.attack1.Location = new System.Drawing.Point(114, 398);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(284, 23);
            this.attack1.TabIndex = 3;
            this.attack1.Text = "attack";
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(114, 485);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(284, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(495, 485);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(278, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // potionicon
            // 
            this.potionicon.Image = global::battlesim.Properties.Resources.potion;
            this.potionicon.Location = new System.Drawing.Point(1, 12);
            this.potionicon.Name = "potionicon";
            this.potionicon.Size = new System.Drawing.Size(36, 36);
            this.potionicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potionicon.TabIndex = 6;
            this.potionicon.TabStop = false;
            // 
            // potions
            // 
            this.potions.AutoSize = true;
            this.potions.Location = new System.Drawing.Point(43, 28);
            this.potions.Name = "potions";
            this.potions.Size = new System.Drawing.Size(13, 15);
            this.potions.TabIndex = 7;
            this.potions.Text = "1";
            // 
            // heal1
            // 
            this.heal1.Location = new System.Drawing.Point(114, 427);
            this.heal1.Name = "heal1";
            this.heal1.Size = new System.Drawing.Size(284, 23);
            this.heal1.TabIndex = 8;
            this.heal1.Text = "heal";
            this.heal1.UseVisualStyleBackColor = true;
            this.heal1.Click += new System.EventHandler(this.heal1_Click);
            // 
            // heal2
            // 
            this.heal2.Location = new System.Drawing.Point(495, 427);
            this.heal2.Name = "heal2";
            this.heal2.Size = new System.Drawing.Size(278, 23);
            this.heal2.TabIndex = 9;
            this.heal2.Text = "heal";
            this.heal2.UseVisualStyleBackColor = true;
            this.heal2.Click += new System.EventHandler(this.heal2_Click);
            // 
            // potions2
            // 
            this.potions2.AutoSize = true;
            this.potions2.Location = new System.Drawing.Point(860, 22);
            this.potions2.Name = "potions2";
            this.potions2.Size = new System.Drawing.Size(13, 15);
            this.potions2.TabIndex = 10;
            this.potions2.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::battlesim.Properties.Resources.potion;
            this.pictureBox1.Location = new System.Drawing.Point(879, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // special1
            // 
            this.special1.Location = new System.Drawing.Point(114, 456);
            this.special1.Name = "special1";
            this.special1.Size = new System.Drawing.Size(284, 23);
            this.special1.TabIndex = 12;
            this.special1.Text = "special";
            this.special1.UseVisualStyleBackColor = true;
            this.special1.Click += new System.EventHandler(this.special1_Click);
            // 
            // special2
            // 
            this.special2.Location = new System.Drawing.Point(495, 456);
            this.special2.Name = "special2";
            this.special2.Size = new System.Drawing.Size(278, 23);
            this.special2.TabIndex = 13;
            this.special2.Text = "special";
            this.special2.UseVisualStyleBackColor = true;
            this.special2.Click += new System.EventHandler(this.special2_Click);
            // 
            // specialattack
            // 
            this.specialattack.AutoSize = true;
            this.specialattack.Location = new System.Drawing.Point(43, 62);
            this.specialattack.Name = "specialattack";
            this.specialattack.Size = new System.Drawing.Size(13, 15);
            this.specialattack.TabIndex = 14;
            this.specialattack.Text = "1";
            // 
            // specialattack2
            // 
            this.specialattack2.AutoSize = true;
            this.specialattack2.Location = new System.Drawing.Point(860, 62);
            this.specialattack2.Name = "specialattack2";
            this.specialattack2.Size = new System.Drawing.Size(13, 15);
            this.specialattack2.TabIndex = 15;
            this.specialattack2.Text = "1";
            // 
            // rounds
            // 
            this.rounds.AutoSize = true;
            this.rounds.Location = new System.Drawing.Point(447, 12);
            this.rounds.Name = "rounds";
            this.rounds.Size = new System.Drawing.Size(13, 15);
            this.rounds.TabIndex = 16;
            this.rounds.Text = "0";
            // 
            // playerturn1
            // 
            this.playerturn1.AutoSize = true;
            this.playerturn1.Location = new System.Drawing.Point(251, 12);
            this.playerturn1.Name = "playerturn1";
            this.playerturn1.Size = new System.Drawing.Size(13, 15);
            this.playerturn1.TabIndex = 17;
            this.playerturn1.Text = "0";
            // 
            // playerturn2
            // 
            this.playerturn2.AutoSize = true;
            this.playerturn2.Location = new System.Drawing.Point(631, 12);
            this.playerturn2.Name = "playerturn2";
            this.playerturn2.Size = new System.Drawing.Size(13, 15);
            this.playerturn2.TabIndex = 18;
            this.playerturn2.Text = "0";
            // 
            // specialicon1
            // 
            this.specialicon1.Image = global::battlesim.Properties.Resources.starexplosion;
            this.specialicon1.Location = new System.Drawing.Point(1, 54);
            this.specialicon1.Name = "specialicon1";
            this.specialicon1.Size = new System.Drawing.Size(36, 36);
            this.specialicon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.specialicon1.TabIndex = 19;
            this.specialicon1.TabStop = false;
            // 
            // specialicon2
            // 
            this.specialicon2.Image = global::battlesim.Properties.Resources.starexplosion;
            this.specialicon2.Location = new System.Drawing.Point(879, 54);
            this.specialicon2.Name = "specialicon2";
            this.specialicon2.Size = new System.Drawing.Size(36, 36);
            this.specialicon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.specialicon2.TabIndex = 20;
            this.specialicon2.TabStop = false;
            // 
            // explore
            // 
            this.explore.Location = new System.Drawing.Point(404, 369);
            this.explore.Name = "explore";
            this.explore.Size = new System.Drawing.Size(85, 23);
            this.explore.TabIndex = 21;
            this.explore.Text = "find items";
            this.explore.UseVisualStyleBackColor = true;
            this.explore.Click += new System.EventHandler(this.explore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 546);
            this.Controls.Add(this.explore);
            this.Controls.Add(this.specialicon2);
            this.Controls.Add(this.specialicon1);
            this.Controls.Add(this.playerturn2);
            this.Controls.Add(this.playerturn1);
            this.Controls.Add(this.rounds);
            this.Controls.Add(this.specialattack2);
            this.Controls.Add(this.specialattack);
            this.Controls.Add(this.special2);
            this.Controls.Add(this.special1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.potions2);
            this.Controls.Add(this.heal2);
            this.Controls.Add(this.heal1);
            this.Controls.Add(this.potions);
            this.Controls.Add(this.potionicon);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.attack1);
            this.Controls.Add(this.attack2);
            this.Controls.Add(this.playericon2);
            this.Controls.Add(this.playericon1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playericon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playericon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialicon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialicon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox playericon1;
        private PictureBox playericon2;
        private Button attack2;
        private Button attack1;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private PictureBox potionicon;
        private Label potions;
        private Button heal1;
        private Button heal2;
        private Label potions2;
        private PictureBox pictureBox1;
        private Button special1;
        private Button special2;
        private Label specialattack;
        private Label specialattack2;
        private Label rounds;
        private Label playerturn1;
        private Label playerturn2;
        private PictureBox specialicon1;
        private PictureBox specialicon2;
        private Button explore;
    }
}