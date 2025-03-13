using System;

namespace pikachu
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
        private void btnPikachu_Click(object sender, EventArgs e)
        {
            DisplayPokemonData("Pikachu");
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPikachu = new System.Windows.Forms.Button();
            this.btnCharmander = new System.Windows.Forms.Button();
            this.btnSquirtle = new System.Windows.Forms.Button();
            this.btnkabigon = new System.Windows.Forms.Button();
            this.btnJigglypuff = new System.Windows.Forms.Button();
            this.btnEevee = new System.Windows.Forms.Button();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPikachu
            // 
            this.btnPikachu.Location = new System.Drawing.Point(527, 12);
            this.btnPikachu.Name = "btnPikachu";
            this.btnPikachu.Size = new System.Drawing.Size(206, 44);
            this.btnPikachu.TabIndex = 0;
            this.btnPikachu.Text = "Pikachu";
            this.btnPikachu.UseVisualStyleBackColor = true;
            this.btnPikachu.Click += new System.EventHandler(this.btnPikachu_Click);
            // 
            // btnCharmander
            // 
            this.btnCharmander.Location = new System.Drawing.Point(527, 344);
            this.btnCharmander.Name = "btnCharmander";
            this.btnCharmander.Size = new System.Drawing.Size(206, 44);
            this.btnCharmander.TabIndex = 1;
            this.btnCharmander.Text = "Charmander";
            this.btnCharmander.UseVisualStyleBackColor = true;
            // 
            // btnSquirtle
            // 
            this.btnSquirtle.Location = new System.Drawing.Point(527, 277);
            this.btnSquirtle.Name = "btnSquirtle";
            this.btnSquirtle.Size = new System.Drawing.Size(206, 44);
            this.btnSquirtle.TabIndex = 2;
            this.btnSquirtle.Text = "Squirtle";
            this.btnSquirtle.UseVisualStyleBackColor = true;
            // 
            // btnkabigon
            // 
            this.btnkabigon.Location = new System.Drawing.Point(527, 79);
            this.btnkabigon.Name = "btnkabigon";
            this.btnkabigon.Size = new System.Drawing.Size(206, 44);
            this.btnkabigon.TabIndex = 3;
            this.btnkabigon.Text = "kabigon";
            this.btnkabigon.UseVisualStyleBackColor = true;
            // 
            // btnJigglypuff
            // 
            this.btnJigglypuff.Location = new System.Drawing.Point(527, 141);
            this.btnJigglypuff.Name = "btnJigglypuff";
            this.btnJigglypuff.Size = new System.Drawing.Size(206, 44);
            this.btnJigglypuff.TabIndex = 4;
            this.btnJigglypuff.Text = "Jigglypuff";
            this.btnJigglypuff.UseVisualStyleBackColor = true;
            // 
            // btnEevee
            // 
            this.btnEevee.Location = new System.Drawing.Point(527, 212);
            this.btnEevee.Name = "btnEevee";
            this.btnEevee.Size = new System.Drawing.Size(206, 44);
            this.btnEevee.TabIndex = 5;
            this.btnEevee.Text = "Eevee";
            this.btnEevee.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Image = global::pikachu.Properties.Resources.kabigon;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(69, -20);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(384, 317);
            this.pictureBoxPokemon.TabIndex = 6;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(105, 318);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Pikachu";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(121, 358);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(39, 16);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(79, 396);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 16);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Basic Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.btnEevee);
            this.Controls.Add(this.btnJigglypuff);
            this.Controls.Add(this.btnkabigon);
            this.Controls.Add(this.btnSquirtle);
            this.Controls.Add(this.btnCharmander);
            this.Controls.Add(this.btnPikachu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPikachu;
        private System.Windows.Forms.Button btnCharmander;
        private System.Windows.Forms.Button btnSquirtle;
        private System.Windows.Forms.Button btnkabigon;
        private System.Windows.Forms.Button btnJigglypuff;
        private System.Windows.Forms.Button btnEevee;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelStatus;
    }
}

