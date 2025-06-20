namespace Course.Render
{
    partial class FormFeed
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
            textBoxSearch = new TextBox();
            panelBandsHorizontalScroll = new Panel();
            flowLayoutBands = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelTitleBands = new Label();
            buttonUserProfile = new Button();
            panelAlbumsHorizontalScroll = new Panel();
            flowLayoutAlbums = new FlowLayoutPanel();
            labelTitleAlbums = new Label();
            panelSongsHorizontalScroll = new Panel();
            flowLayoutSongs = new FlowLayoutPanel();
            labelTitleSongs = new Label();
            panelDropdown = new Panel();
            buttonGenresFilter = new Button();
            checkBoxSearchBands = new CheckBox();
            checkBoxSearchSongs = new CheckBox();
            checkBoxSearchAlbums = new CheckBox();
            groupBoxModifer = new GroupBox();
            radioButtonNot = new RadioButton();
            radioButtonOr = new RadioButton();
            radioButtonAll = new RadioButton();
            buttonSearch = new Button();
            checkedListBoxGenres = new CheckedListBox();
            buttonClearSearchResult = new Button();
            buttonShowAllBands = new Button();
            buttonShowAllAlbums = new Button();
            buttonShowAllSongs = new Button();
            panelBandsHorizontalScroll.SuspendLayout();
            panelAlbumsHorizontalScroll.SuspendLayout();
            panelSongsHorizontalScroll.SuspendLayout();
            panelDropdown.SuspendLayout();
            groupBoxModifer.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top;
            textBoxSearch.Location = new Point(146, 12);
            textBoxSearch.MaximumSize = new Size(457, 23);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(457, 23);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.Click += TextBoxSearch_Click;
            textBoxSearch.Leave += Panel_Leave;
            // 
            // panelBandsHorizontalScroll
            // 
            panelBandsHorizontalScroll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBandsHorizontalScroll.BorderStyle = BorderStyle.FixedSingle;
            panelBandsHorizontalScroll.Controls.Add(flowLayoutBands);
            panelBandsHorizontalScroll.Location = new Point(0, 134);
            panelBandsHorizontalScroll.Name = "panelBandsHorizontalScroll";
            panelBandsHorizontalScroll.Size = new Size(760, 156);
            panelBandsHorizontalScroll.TabIndex = 0;
            // 
            // flowLayoutBands
            // 
            flowLayoutBands.AutoScroll = true;
            flowLayoutBands.Dock = DockStyle.Fill;
            flowLayoutBands.Location = new Point(0, 0);
            flowLayoutBands.Name = "flowLayoutBands";
            flowLayoutBands.Size = new Size(758, 154);
            flowLayoutBands.TabIndex = 0;
            flowLayoutBands.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // labelTitleBands
            // 
            labelTitleBands.Anchor = AnchorStyles.Left;
            labelTitleBands.AutoSize = true;
            labelTitleBands.Location = new Point(0, 120);
            labelTitleBands.Name = "labelTitleBands";
            labelTitleBands.Size = new Size(78, 15);
            labelTitleBands.TabIndex = 0;
            labelTitleBands.Text = "BandsSection";
            // 
            // buttonUserProfile
            // 
            buttonUserProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUserProfile.Location = new Point(693, 11);
            buttonUserProfile.Name = "buttonUserProfile";
            buttonUserProfile.Size = new Size(55, 24);
            buttonUserProfile.TabIndex = 5;
            buttonUserProfile.Text = "Profile";
            buttonUserProfile.UseVisualStyleBackColor = true;
            buttonUserProfile.Click += buttonUserProfile_Click;
            // 
            // panelAlbumsHorizontalScroll
            // 
            panelAlbumsHorizontalScroll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelAlbumsHorizontalScroll.BorderStyle = BorderStyle.FixedSingle;
            panelAlbumsHorizontalScroll.Controls.Add(flowLayoutAlbums);
            panelAlbumsHorizontalScroll.Location = new Point(1, 317);
            panelAlbumsHorizontalScroll.Name = "panelAlbumsHorizontalScroll";
            panelAlbumsHorizontalScroll.Size = new Size(760, 156);
            panelAlbumsHorizontalScroll.TabIndex = 6;
            // 
            // flowLayoutAlbums
            // 
            flowLayoutAlbums.AutoScroll = true;
            flowLayoutAlbums.Dock = DockStyle.Fill;
            flowLayoutAlbums.Location = new Point(0, 0);
            flowLayoutAlbums.Name = "flowLayoutAlbums";
            flowLayoutAlbums.Size = new Size(758, 154);
            flowLayoutAlbums.TabIndex = 0;
            flowLayoutAlbums.WrapContents = false;
            // 
            // labelTitleAlbums
            // 
            labelTitleAlbums.Anchor = AnchorStyles.Left;
            labelTitleAlbums.AutoSize = true;
            labelTitleAlbums.Location = new Point(1, 303);
            labelTitleAlbums.Name = "labelTitleAlbums";
            labelTitleAlbums.Size = new Size(87, 15);
            labelTitleAlbums.TabIndex = 7;
            labelTitleAlbums.Text = "AlbumsSection";
            // 
            // panelSongsHorizontalScroll
            // 
            panelSongsHorizontalScroll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelSongsHorizontalScroll.BorderStyle = BorderStyle.FixedSingle;
            panelSongsHorizontalScroll.Controls.Add(flowLayoutSongs);
            panelSongsHorizontalScroll.Location = new Point(0, 500);
            panelSongsHorizontalScroll.Name = "panelSongsHorizontalScroll";
            panelSongsHorizontalScroll.Size = new Size(760, 156);
            panelSongsHorizontalScroll.TabIndex = 1;
            // 
            // flowLayoutSongs
            // 
            flowLayoutSongs.AutoScroll = true;
            flowLayoutSongs.Dock = DockStyle.Fill;
            flowLayoutSongs.Location = new Point(0, 0);
            flowLayoutSongs.Name = "flowLayoutSongs";
            flowLayoutSongs.Size = new Size(758, 154);
            flowLayoutSongs.TabIndex = 0;
            flowLayoutSongs.WrapContents = false;
            // 
            // labelTitleSongs
            // 
            labelTitleSongs.Anchor = AnchorStyles.Left;
            labelTitleSongs.AutoSize = true;
            labelTitleSongs.Location = new Point(0, 486);
            labelTitleSongs.Name = "labelTitleSongs";
            labelTitleSongs.Size = new Size(78, 15);
            labelTitleSongs.TabIndex = 2;
            labelTitleSongs.Text = "SongsSection";
            // 
            // panelDropdown
            // 
            panelDropdown.Anchor = AnchorStyles.Top;
            panelDropdown.BorderStyle = BorderStyle.FixedSingle;
            panelDropdown.Controls.Add(buttonGenresFilter);
            panelDropdown.Controls.Add(checkBoxSearchBands);
            panelDropdown.Controls.Add(checkBoxSearchSongs);
            panelDropdown.Controls.Add(checkBoxSearchAlbums);
            panelDropdown.Controls.Add(groupBoxModifer);
            panelDropdown.Controls.Add(buttonSearch);
            panelDropdown.Location = new Point(146, 12);
            panelDropdown.Name = "panelDropdown";
            panelDropdown.Size = new Size(483, 110);
            panelDropdown.TabIndex = 8;
            panelDropdown.Visible = false;
            // 
            // buttonGenresFilter
            // 
            buttonGenresFilter.Location = new Point(83, 25);
            buttonGenresFilter.Name = "buttonGenresFilter";
            buttonGenresFilter.Size = new Size(75, 23);
            buttonGenresFilter.TabIndex = 15;
            buttonGenresFilter.Text = "Жанри";
            buttonGenresFilter.UseVisualStyleBackColor = true;
            buttonGenresFilter.Click += buttonGenresFilter_Click;
            buttonGenresFilter.Enter += Panel_Enter;
            buttonGenresFilter.Leave += Panel_Leave;
            // 
            // checkBoxSearchBands
            // 
            checkBoxSearchBands.AutoSize = true;
            checkBoxSearchBands.Location = new Point(3, 25);
            checkBoxSearchBands.Name = "checkBoxSearchBands";
            checkBoxSearchBands.Size = new Size(59, 19);
            checkBoxSearchBands.TabIndex = 14;
            checkBoxSearchBands.Text = "Групи";
            checkBoxSearchBands.UseVisualStyleBackColor = true;
            checkBoxSearchBands.CheckedChanged += ChangeTypeBands;
            checkBoxSearchBands.Enter += Panel_Enter;
            checkBoxSearchBands.Leave += Panel_Leave;
            // 
            // checkBoxSearchSongs
            // 
            checkBoxSearchSongs.AutoSize = true;
            checkBoxSearchSongs.Location = new Point(3, 75);
            checkBoxSearchSongs.Name = "checkBoxSearchSongs";
            checkBoxSearchSongs.Size = new Size(54, 19);
            checkBoxSearchSongs.TabIndex = 13;
            checkBoxSearchSongs.Text = "Пісні";
            checkBoxSearchSongs.UseVisualStyleBackColor = true;
            checkBoxSearchSongs.CheckedChanged += ChangeTypeSongs;
            checkBoxSearchSongs.Enter += Panel_Enter;
            checkBoxSearchSongs.Leave += Panel_Leave;
            // 
            // checkBoxSearchAlbums
            // 
            checkBoxSearchAlbums.AutoSize = true;
            checkBoxSearchAlbums.Location = new Point(3, 50);
            checkBoxSearchAlbums.Name = "checkBoxSearchAlbums";
            checkBoxSearchAlbums.Size = new Size(77, 19);
            checkBoxSearchAlbums.TabIndex = 12;
            checkBoxSearchAlbums.Text = "Альбоми";
            checkBoxSearchAlbums.UseVisualStyleBackColor = true;
            checkBoxSearchAlbums.CheckedChanged += ChangeTypeAlbums;
            checkBoxSearchAlbums.Enter += Panel_Enter;
            checkBoxSearchAlbums.Leave += Panel_Leave;
            // 
            // groupBoxModifer
            // 
            groupBoxModifer.Controls.Add(radioButtonNot);
            groupBoxModifer.Controls.Add(radioButtonOr);
            groupBoxModifer.Controls.Add(radioButtonAll);
            groupBoxModifer.Location = new Point(379, 25);
            groupBoxModifer.Name = "groupBoxModifer";
            groupBoxModifer.Size = new Size(103, 84);
            groupBoxModifer.TabIndex = 10;
            groupBoxModifer.TabStop = false;
            groupBoxModifer.Text = "Модифікатори";
            // 
            // radioButtonNot
            // 
            radioButtonNot.AutoSize = true;
            radioButtonNot.Location = new Point(6, 64);
            radioButtonNot.Name = "radioButtonNot";
            radioButtonNot.Size = new Size(59, 19);
            radioButtonNot.TabIndex = 2;
            radioButtonNot.Text = "Окрім";
            radioButtonNot.UseVisualStyleBackColor = true;
            radioButtonNot.Click += ChangeModifier;
            radioButtonNot.Enter += Panel_Enter;
            radioButtonNot.Leave += Panel_Leave;
            // 
            // radioButtonOr
            // 
            radioButtonOr.AutoSize = true;
            radioButtonOr.Location = new Point(6, 39);
            radioButtonOr.Name = "radioButtonOr";
            radioButtonOr.Size = new Size(87, 19);
            radioButtonOr.TabIndex = 1;
            radioButtonOr.Text = "Лише один";
            radioButtonOr.UseVisualStyleBackColor = true;
            radioButtonOr.Click += ChangeModifier;
            radioButtonOr.Enter += Panel_Enter;
            radioButtonOr.Leave += Panel_Leave;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Checked = true;
            radioButtonAll.Location = new Point(6, 14);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(41, 19);
            radioButtonAll.TabIndex = 0;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "Всі";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.Click += ChangeModifier;
            radioButtonAll.Enter += Panel_Enter;
            radioButtonAll.Leave += Panel_Leave;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(455, -1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(27, 24);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "🔍";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += PerformSearch;
            buttonSearch.Enter += Panel_Enter;
            buttonSearch.Leave += Panel_Leave;
            // 
            // checkedListBoxGenres
            // 
            checkedListBoxGenres.Anchor = AnchorStyles.Top;
            checkedListBoxGenres.FormattingEnabled = true;
            checkedListBoxGenres.Items.AddRange(new object[] { "Rock", "Pop", "Hip Hop", "Electronic", "Jazz", "Blues", "Classical", "R&B", "Country", "Reggae", "Folk", "Metal", "Punk", "Funk", "Soul", "Disco", "House", "Techno", "Ambient", "Indie", "Alternative" });
            checkedListBoxGenres.Location = new Point(230, 65);
            checkedListBoxGenres.Name = "checkedListBoxGenres";
            checkedListBoxGenres.Size = new Size(120, 220);
            checkedListBoxGenres.TabIndex = 9;
            checkedListBoxGenres.Visible = false;
            checkedListBoxGenres.ItemCheck += checkedListBoxGenres_ItemCheck;
            checkedListBoxGenres.Enter += Panel_Enter;
            checkedListBoxGenres.Leave += Panel_Leave;
            // 
            // buttonClearSearchResult
            // 
            buttonClearSearchResult.Location = new Point(12, 11);
            buttonClearSearchResult.Name = "buttonClearSearchResult";
            buttonClearSearchResult.Size = new Size(110, 23);
            buttonClearSearchResult.TabIndex = 10;
            buttonClearSearchResult.Text = "Очистити пошук";
            buttonClearSearchResult.UseVisualStyleBackColor = true;
            buttonClearSearchResult.Visible = false;
            buttonClearSearchResult.Click += buttonClearSearchResult_Click;
            // 
            // buttonShowAllBands
            // 
            buttonShowAllBands.Anchor = AnchorStyles.Right;
            buttonShowAllBands.Location = new Point(729, 113);
            buttonShowAllBands.Name = "buttonShowAllBands";
            buttonShowAllBands.Size = new Size(32, 22);
            buttonShowAllBands.TabIndex = 11;
            buttonShowAllBands.Text = "Всі";
            buttonShowAllBands.UseVisualStyleBackColor = true;
            buttonShowAllBands.Click += buttonShowAllBands_Click;
            // 
            // buttonShowAllAlbums
            // 
            buttonShowAllAlbums.Anchor = AnchorStyles.Right;
            buttonShowAllAlbums.Location = new Point(729, 296);
            buttonShowAllAlbums.Name = "buttonShowAllAlbums";
            buttonShowAllAlbums.Size = new Size(32, 22);
            buttonShowAllAlbums.TabIndex = 12;
            buttonShowAllAlbums.Text = "Всі";
            buttonShowAllAlbums.UseVisualStyleBackColor = true;
            buttonShowAllAlbums.Click += buttonShowAllAlbums_Click;
            // 
            // buttonShowAllSongs
            // 
            buttonShowAllSongs.Anchor = AnchorStyles.Right;
            buttonShowAllSongs.Location = new Point(728, 479);
            buttonShowAllSongs.Name = "buttonShowAllSongs";
            buttonShowAllSongs.Size = new Size(32, 22);
            buttonShowAllSongs.TabIndex = 13;
            buttonShowAllSongs.Text = "Всі";
            buttonShowAllSongs.UseVisualStyleBackColor = true;
            buttonShowAllSongs.Click += buttonShowAllSongs_Click;
            // 
            // FormFeed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 668);
            Controls.Add(buttonShowAllSongs);
            Controls.Add(buttonShowAllAlbums);
            Controls.Add(buttonShowAllBands);
            Controls.Add(buttonClearSearchResult);
            Controls.Add(checkedListBoxGenres);
            Controls.Add(panelSongsHorizontalScroll);
            Controls.Add(labelTitleSongs);
            Controls.Add(panelAlbumsHorizontalScroll);
            Controls.Add(labelTitleAlbums);
            Controls.Add(panelBandsHorizontalScroll);
            Controls.Add(labelTitleBands);
            Controls.Add(buttonUserProfile);
            Controls.Add(textBoxSearch);
            Controls.Add(panelDropdown);
            MaximumSize = new Size(1120, 900);
            MinimumSize = new Size(776, 707);
            Name = "FormFeed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feed";
            Load += MainForm_Load;
            panelBandsHorizontalScroll.ResumeLayout(false);
            panelAlbumsHorizontalScroll.ResumeLayout(false);
            panelSongsHorizontalScroll.ResumeLayout(false);
            panelDropdown.ResumeLayout(false);
            panelDropdown.PerformLayout();
            groupBoxModifer.ResumeLayout(false);
            groupBoxModifer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected TextBox textBoxSearch;
        protected Label labelTitleBands;
        protected Button buttonUserProfile;
        protected Panel panelBandsHorizontalScroll;
        protected Controls.ObjectControl objectControl1;
        protected FlowLayoutPanel flowLayoutPanel1;
        protected Panel panelAlbumsHorizontalScroll;
        protected Label labelTitleAlbums;
        protected Panel panelSongsHorizontalScroll;
        protected Label labelTitleSongs;
        protected Panel panelDropdown;
        protected Button buttonSearch;
        protected GroupBox groupBoxModifer;
        protected FlowLayoutPanel flowLayoutBands;
        protected FlowLayoutPanel flowLayoutAlbums;
        protected FlowLayoutPanel flowLayoutSongs;
        protected RadioButton radioButtonNot;
        protected RadioButton radioButtonOr;
        protected RadioButton radioButtonAll;
        private CheckBox checkBoxSearchBands;
        private CheckBox checkBoxSearchSongs;
        private CheckBox checkBoxSearchAlbums;
        private Button buttonGenresFilter;
        private CheckedListBox checkedListBoxGenres;
        private Button button1;
        private Button buttonShowAllBands;
        private Button buttonShowAllAlbums;
        private Button buttonShowAllSongs;
        protected Button buttonClearSearchResult;
    }
}