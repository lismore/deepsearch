using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DeepWeb;
using DeepSearch;

namespace DeepGoogle
{
    /**
     * Class Name       :   frmOne
     * Author           :   Patrick Lismore
     * Date             :   21/March/2008
     **/
    public partial class frmOne : Form
    {
        // Change the type of the panel to StatusBarProgressPanel on your Form

       /**
         *Method Name   :   frmOne
         * Discription  :   Initializes the component
         * 
         **/
        public frmOne()
        {
            InitializeComponent();
        }

        /**
         * Method Name      :   frmOne_Load
         * Discription      :   This method is called when 
         *                      the windows form loads, it simply
         *                      sets the search box as the focus
         * Parameters       :   sender, e
         * 
         **/
        private void frmOne_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.TabIndex = 0;
              

        }

        /**
         * Method Name      :   btnSearch_Click
         * Discription      :   takes a users search query 
         *                      passes the query to the DeepWeb
         *                      dll to add the advanced operaters
         *                      and presents the results to the user
         * Parameters       :   sender , e
         * 
         * */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            #region local variables
            //**************************************
            //assign search query to String variable
            String query = txtSearch.Text;
            //**************************************
            //create string variables 
            String SearchType = "";
            String Full = "";
            String lang = "";
            //create int cariables 
            int tool = 0;
            //create an object from the DeepWeb Dll
            DeepWeb.Search ds = new Search();
            //**************************************
            #endregion
            
            #region Music;
            //***************************************
            //Search for Music 
            //***************************************
            if (tabControl.SelectedIndex == 0)
            {
                //***********************************
                //find which music file checkbox is 
                //checked
                //***********************************
                if (cbMp3.Checked == true)
                {
                    //Adds the file type mp3 to the variable SearchType
                    SearchType = SearchType + "|.mp3";
                }

                if (cbOgg.Checked == true)
                {
                    //Adds the file type ogg to the variable SearchType
                    SearchType = SearchType + "|.ogg";
                }

                if (cbWma.Checked == true)
                {
                    //Adds the file type wma to the variable SearchType
                    SearchType = SearchType + "|.wma";
                }
                if (cbFlac.Checked == true)
                {
                    //Adds the file type flac to the variable SearchType
                    SearchType = SearchType + "|.flac";
                }
                if (cbWav.Checked == true)
                {
                    //Adds the file type wav to the variable SearchType
                    SearchType = SearchType + "|.wav";
                }
                if (cbAu.Checked == true)
                {
                    //Adds the file type au to the variable SearchType
                    SearchType = SearchType + "|.au";
                }
                if (cbAiff.Checked == true)
                {
                    //Adds the file type aiff to the variable SearchType
                    SearchType = SearchType + "|.aiff";
                }
                if (cbRa.Checked == true)
                {
                    //Adds the file type ra to the variable SearchType
                    SearchType = SearchType + "|.ra";
                }
                if (cbRam.Checked == true)
                {
                    //Adds the file type ram to the variable SearchType
                    SearchType = SearchType + "|.ram";
                }
                if (cbVox.Checked == true)
                {
                    //Adds the file type vox to the variable SearchType
                    SearchType = SearchType + "|.vox";
                }
                if (cbDct.Checked == true)
                {
                    //Adds the file type dct to the variable SearchType
                    SearchType = SearchType + "|.dct";
                }
                if (cbGsm.Checked == true)
                {
                    //Adds the file type gsm to the variable SearchType
                    SearchType = SearchType + "|.gsm";
                }

            }
            #endregion
            #region Video
            //***************************************
            //Search for Video
            //***************************************
            if (tabControl.SelectedIndex == 1)
            {
                if (cbWmv.Checked == true)
                {
                    //Adds the file type wmv to the variable SearchType
                    SearchType = SearchType + "|.wmv";
                }

                if (cbAvi.Checked == true)
                {
                    //Adds the file type avi to the variable SearchType
                    SearchType = SearchType + "|.avi";
                }

                if (cbMpg.Checked == true)
                {
                    //Adds the file type mpg to the variable SearchType
                    SearchType = SearchType + "|.mpg";
                }
                if (cbMpeg.Checked == true)
                {

                    //Adds the file type mpeg to the variable SearchType
                    SearchType = SearchType + "|.mpeg";
                }
                if (cbMp4.Checked == true)
                {

                    //Adds the file type mp4 to the variable SearchType
                    SearchType = SearchType + "|.mp4";
                }
                if (cbFlash.Checked == true)
                {

                    //Adds the file type flv to the variable SearchType
                    SearchType = SearchType + "|.flv";
                }
                if (cb3gp.Checked == true)
                {

                    //Adds the file type 3gp to the variable SearchType
                    SearchType = SearchType + "|.3gp";
                }
                if (cbDivx.Checked == true)
                {

                    //Adds the file type divx to the variable SearchType
                    SearchType = SearchType + "|.divx";
                }
                if (cbMov.Checked == true)
                {

                    //Adds the file type mov to the variable SearchType
                    SearchType = SearchType + "|.mov";
                }
                if (cbSwf.Checked == true)
                {

                    //Adds the file type mp3 to the variable SearchType
                    SearchType = SearchType + "|.swf";
                }
                if (cbAsf.Checked == true)
                {

                    //Adds the file type asf to the variable SearchType
                    SearchType = SearchType + "|.asf";
                }
                if (cbAsx.Checked == true)
                {

                    //Adds the file type asx to the variable SearchType
                    SearchType = SearchType + "|.asx";
                }

            }
            #endregion
            #region Books
            //***************************************
            //Search for Books/Documents 
            //***************************************
            if (tabControl.SelectedIndex == 2)
            {
                if (cbClass.Checked == true)
                {
                    //Adds the file type class to the variable SearchType
                    SearchType = SearchType + "|.class";
                }

                if (cbCs.Checked == true)
                {
                    //Adds the file type cs to the variable SearchType
                    SearchType = SearchType + "|.cs";
                }

                if (cbDoc.Checked == true)
                {
                    //Adds the file type doc to the variable SearchType
                    SearchType = SearchType + "|.doc";
                }
            }
            if (cbPdf.Checked == true)
            {
                //Adds the file type pdf to the variable SearchType
                SearchType = SearchType + "|.pdf";
            }
            if (cbRtf.Checked == true)
            {
                //Adds the file type rtf to the variable SearchType
                SearchType = SearchType + "|.rtf";
            }
            if (cbTxt.Checked == true)
            {
                //Adds the file type asx to the variable SearchType
                SearchType = SearchType + "|.txt";
            }
            if (cbChm.Checked == true)
            {
                //Adds the file type chm to the variable SearchType
                SearchType = SearchType + "|.chm";
            }
            if (cbDocx.Checked == true)
            {
                //Adds the file type docx to the variable SearchType
                SearchType = SearchType + "|.docx";
            }
            if (cbJava.Checked == true)
            {
                //Adds the file type java to the variable SearchType
                SearchType = SearchType + "|.java";
            }
            if (cbXml.Checked == true)
            {
                //Adds the file type asx to the variable SearchType
                SearchType = SearchType + "|.xml";
            }


            #endregion
            #region Applications
            if (tabControl.SelectedIndex == 4)
            {

                if (cbZip.Checked == true)
                {
                    //Adds the file type zip to the variable SearchType
                    SearchType = SearchType + "|.zip";
                }

                if (cbRar.Checked == true)
                {
                    //Adds the file type rar to the variable SearchType
                    SearchType = SearchType + "|.rar";
                }

                if (cbExe.Checked == true)
                {
                    //Adds the file type exe to the variable SearchType
                    SearchType = SearchType + "|.exe";
                }

                if (cbIso.Checked == true)
                {
                    //Adds the file type iso to the variable SearchType
                    SearchType = SearchType + "|.iso";
                }
                if (cbBat.Checked == true)
                {
                    //Adds the file type bat to the variable SearchType
                    SearchType = SearchType + "|.bat";
                }
                if (cbJar.Checked == true)
                {
                    //Adds the file type jar to the variable SearchType
                    SearchType = SearchType + "|.jar";
                }
                if (cbTar.Checked == true)
                {
                    //Adds the file type tar to the variable SearchType
                    SearchType = SearchType + "|.tar";
                }

            }
            #endregion
            
            #region Images

            if (tabControl.SelectedIndex == 11)
            {
                
                    if (cbJpeg.Checked == true)
                    {
                        //Adds the file type jpeg to the variable SearchType
                        SearchType = SearchType + "|.jpeg";
                    }

                    if (cbJpg.Checked == true)
                    {
                        //Adds the file type jpg to the variable SearchType
                        SearchType = SearchType + "|.jpg";
                    }

                    if (cbPng.Checked == true)
                    {
                        //Adds the file type png to the variable SearchType
                        SearchType = SearchType + "|.png";
                    }
                    if (cbBmp.Checked == true)
                    {
                        //Adds the file type bmp to the variable SearchType
                        SearchType = SearchType + "|.bmp";
                    }
                    if (cbTiff.Checked == true)
                    {
                        //Adds the file type tif to the variable SearchType
                        SearchType = SearchType + "|.tif";
                    }
                    if (cbGiff.Checked == true)
                    {
                        //Adds the file type gif to the variable SearchType
                        SearchType = SearchType + "|.gif";
                    }

                }
            #endregion
            #region Tools
                if (tabControl.SelectedIndex == 3)
                {
                    if (rbLinks.Checked == true)
                    {
                        tool = 1;
                    }
                    if (rbAdd.Checked == true)
                    {
                        tool = 2;
                    }
                    if (rbRelated.Checked == true)
                    {
                        tool = 3;
                    }
                    if (rbIndex.Checked == true)
                    {
                        tool = 4;
                    }

                }

                #endregion
                
            #region AdminTools
                if (tabControl.SelectedIndex == 5)
                {
                    if (rbAuth.Checked == true)
                    {
                        tool = 1;
                    }
                    if (rbConfig.Checked == true)
                    {
                        tool = 2;
                    }
                    if (rbPass.Checked == true)
                    {
                        tool = 3;
                    }
                    if (rbPassurl.Checked == true)
                    {
                        tool = 4;
                    }

                }

            #endregion
            #region Translate

                if (tabControl.SelectedIndex == 9)
                {
                    if (rbEnDe.Checked == true)
                    {
                        lang = "ende";
                    }
                }
                #endregion
                
                // resets the search text box back to blank
                txtSearch.Text = "";

                // passes the users search query & the SearchTypes
                // to the DeepWeb DLL which will build the DeepSearch
                // Goolge query and pass back a URL for the web browser
                if (tabControl.SelectedIndex == 0 || tabControl.SelectedIndex == 1 || tabControl.SelectedIndex == 2 || tabControl.SelectedIndex == 4 || tabControl.SelectedIndex == 11)
                {
                    //check boxes , Music, Video, Documents, Applications, Images
                    Full = ds.DeepSearch(query, SearchType);
                }
                else if (tabControl.SelectedIndex == 3)
                {
                    // Tools
                    Full = ds.DeepTool(query, tool);
                }
                else if (tabControl.SelectedIndex == 5)
                {
                    // Admin Tools
                    Full = ds.DeepAdmin(query, tool);
                }
                else if (tabControl.SelectedIndex == 6)
                {
                    // Torrents
                    Full = ds.DeepTorrent(query);
                }
                else if (tabControl.SelectedIndex == 7)
                {
                    // Fonts
                    Full = ds.DeepFonts(query);
                }
                else if (tabControl.SelectedIndex == 8)
                {
                    //Lyrics
                    Full = ds.DeepLyrics(query);
                }
                else if (tabControl.SelectedIndex == 9)
                {
                    //Translate
                    Full = ds.DeepTranslate(query, lang);
                }
                else if (tabControl.SelectedIndex == 10)
                {
                    //Maps
                    Full = ds.DeepMap(query);
                }
                
                // The web browser is told to go to google and query 
                // with some advanced operators and the users query and
                // the file type
                webBrowser1.Navigate(Full, false);
                
                //Reset the SearchType and Full Strings back to null
                SearchType = "";
                Full = "";
                
                
        }

        /**
         * Method Name      :   webBrowser1_ProgessChanged
         * Discription      :   This method controls the progress bar, the progress
         *                      bar will move as the web page loads
         * Parameters       :   sender, e
         * 
         **/
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)(((double)e.CurrentProgress / e.MaximumProgress) * 100);
            txtSearch.Text = "";
            
        }

        /**
         * Method Name      :   btnBack_Click
         * Discription      :   This method will make the web browser go 
         *                      back to the last page
         * Parameters       :   sender, e
         **/
        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

        }

        /**
         * Method Name      :   btnForward_Click
         * Discription      :   This method will make the web browser go 
         *                      forward if there is a page to go forward to
         * 
         * Parameters       :   sender, e
         **/
        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        /**
         * Method Name      :   btnHome_Click
         * Discription      :   This method will navigate the web browser 
         *                      to the original start page
         * Parameters       :   sender, e
         * 
         **/
        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://code.google.com/p/deepsearch/", false);
        }

        /**
         * Method Name      :   exitToolStripMenuItem_Click
         * Discription      :   This method is called when Exit is clicked
         *                      on the toolbar, it will end the application
         * parameters       :   sender, e
         * 
         **/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Method Name      :   aboutToolStripMenuItem_Click
         * Discription      :   This method will open the AboutBox
         * Parameters       :   sender, e
         **/
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();

        }

        
    }

}