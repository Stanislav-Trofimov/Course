namespace Course.Render.Forms
{
    partial class FormAddNewPlaylist
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
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxEnterName = new TextBox();
            labelName = new Label();
            pictureBoxPreviewIcon = new PictureBox();
            buttonIconChoose = new Button();
            labelIcon = new Label();
            checkedListBoxGenres = new CheckedListBox();
            labelGenres = new Label();
            panel1 = new Panel();
            labelPreview = new Label();
            labelPreviewGenres = new Label();
            labelPreviewName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreviewIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(388, 228);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(307, 228);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxEnterName
            // 
            textBoxEnterName.Location = new Point(59, 9);
            textBoxEnterName.Name = "textBoxEnterName";
            textBoxEnterName.Size = new Size(100, 23);
            textBoxEnterName.TabIndex = 2;
            textBoxEnterName.TextChanged += textBoxEnterName_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Назва";
            // 
            // pictureBoxPreviewIcon
            // 
            pictureBoxPreviewIcon.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPreviewIcon.Location = new Point(3, 31);
            pictureBoxPreviewIcon.Name = "pictureBoxPreviewIcon";
            pictureBoxPreviewIcon.Size = new Size(110, 110);
            pictureBoxPreviewIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreviewIcon.TabIndex = 4;
            pictureBoxPreviewIcon.TabStop = false;
            // 
            // buttonIconChoose
            // 
            buttonIconChoose.Location = new Point(59, 37);
            buttonIconChoose.Name = "buttonIconChoose";
            buttonIconChoose.Size = new Size(75, 23);
            buttonIconChoose.TabIndex = 5;
            buttonIconChoose.Text = "Обрати";
            buttonIconChoose.UseVisualStyleBackColor = true;
            buttonIconChoose.Click += buttonIconChoose_Click;
            // 
            // labelIcon
            // 
            labelIcon.AutoSize = true;
            labelIcon.Location = new Point(12, 41);
            labelIcon.Name = "labelIcon";
            labelIcon.Size = new Size(42, 15);
            labelIcon.TabIndex = 6;
            labelIcon.Text = "Іконка";
            // 
            // checkedListBoxGenres
            // 
            checkedListBoxGenres.FormattingEnabled = true;
            checkedListBoxGenres.Items.AddRange(new object[] { "Rock", "Pop", "Hip Hop", "Electronic", "Jazz", "Blues", "Classical", "R&B", "Country", "Reggae", "Folk", "Metal", "Punk", "Funk", "Soul", "Disco", "House", "Techno", "Ambient", "Indie", "Alternative " });
            checkedListBoxGenres.Location = new Point(59, 66);
            checkedListBoxGenres.Name = "checkedListBoxGenres";
            checkedListBoxGenres.Size = new Size(121, 184);
            checkedListBoxGenres.TabIndex = 7;
            checkedListBoxGenres.SelectedIndexChanged += checkedListBoxGenres_SelectedIndexChanged;
            // 
            // labelGenres
            // 
            labelGenres.AutoSize = true;
            labelGenres.Location = new Point(12, 66);
            labelGenres.Name = "labelGenres";
            labelGenres.Size = new Size(45, 15);
            labelGenres.TabIndex = 8;
            labelGenres.Text = "Жанри";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelPreview);
            panel1.Controls.Add(labelPreviewGenres);
            panel1.Controls.Add(labelPreviewName);
            panel1.Controls.Add(pictureBoxPreviewIcon);
            panel1.Location = new Point(220, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 172);
            panel1.TabIndex = 9;
            // 
            // labelPreview
            // 
            labelPreview.AutoSize = true;
            labelPreview.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPreview.Location = new Point(32, 2);
            labelPreview.Name = "labelPreview";
            labelPreview.Size = new Size(183, 21);
            labelPreview.TabIndex = 7;
            labelPreview.Text = "Попередній перегляд";
            // 
            // labelPreviewGenres
            // 
            labelPreviewGenres.AutoSize = true;
            labelPreviewGenres.Location = new Point(3, 144);
            labelPreviewGenres.Name = "labelPreviewGenres";
            labelPreviewGenres.Size = new Size(48, 15);
            labelPreviewGenres.TabIndex = 6;
            labelPreviewGenres.Text = "Жанри:";
            // 
            // labelPreviewName
            // 
            labelPreviewName.AutoSize = true;
            labelPreviewName.Font = new Font("Arial", 10F, FontStyle.Bold);
            labelPreviewName.Location = new Point(119, 37);
            labelPreviewName.Name = "labelPreviewName";
            labelPreviewName.Size = new Size(49, 16);
            labelPreviewName.TabIndex = 5;
            labelPreviewName.Text = "Назва";
            // 
            // FormAddNewPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 257);
            Controls.Add(panel1);
            Controls.Add(labelGenres);
            Controls.Add(labelName);
            Controls.Add(checkedListBoxGenres);
            Controls.Add(labelIcon);
            Controls.Add(buttonSave);
            Controls.Add(buttonIconChoose);
            Controls.Add(textBoxEnterName);
            Controls.Add(buttonCancel);
            MaximumSize = new Size(485, 296);
            MinimumSize = new Size(485, 296);
            Name = "FormAddNewPlaylist";
            Text = "FormAddNewPlaylist";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreviewIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxEnterName;
        private Label labelName;
        private PictureBox pictureBoxPreviewIcon;
        private Button buttonIconChoose;
        private Label labelIcon;
        private CheckedListBox checkedListBoxGenres;
        private Label labelGenres;
        private Panel panel1;
        private Label labelPreview;
        private Label labelPreviewGenres;
        private Label labelPreviewName;
    }
}