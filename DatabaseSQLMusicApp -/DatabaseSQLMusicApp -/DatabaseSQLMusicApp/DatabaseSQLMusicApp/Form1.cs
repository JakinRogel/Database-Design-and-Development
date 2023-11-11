namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAlbumsButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            
            //connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;

           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.searchTitles
                (SearchTxtBox.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[4]
                .Value.ToString();

            try
            {
                pictureBox1.Load(imageURL);
            }
            catch (Exception)
            { 
                
            }

            /*
            AlbumsDAO albumsDAO = new AlbumsDAO();

            tracksBindingSource.DataSource = albumsDAO.getTracksUsingJoin((int)
                dataGridView.Rows[rowClicked].Cells[0].Value);
            */
            AlbumsDAO albumsDao = new AlbumsDAO();
            albums = albumsDao.getAllAlbums();
            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            //tracksBindingSource.DataSource = AlbumsDAO.albums[rowClicked].Tracks;
            /*
             * tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            The above code consistently throws an out of bounds error for index
            AlbumsDAO needed to be instantiated and then getAllALlbums called for it to work */

            dataGridView2.DataSource = tracksBindingSource;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //add a new item to the database
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_artist.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_imageURL.Text,
                Description = txt_des.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;

            //MessageBox.Show("You clicked row " + rowClicked);

            String videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();

            //MessageBox.Show("URL=" + videoURL);
            webView21.Source = new Uri(videoURL);


        }

        private void deleteTrackBtn_Click(object sender, EventArgs e)
        {
            //get the row number clicked
            int rowClicked = dataGridView2.CurrentRow.Index;
            //MessageBox.Show("You clicked row " + rowClicked);
            int trackID = int.Parse(dataGridView2.Rows[rowClicked].Cells[0].Value.ToString());
            //MessageBox.Show("ID of track " + trackID);

            AlbumsDAO albumsDao = new AlbumsDAO();

            int result = albumsDao.deleteTrack(trackID);

            MessageBox.Show("Result " + result);

            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();
        }
    }
}