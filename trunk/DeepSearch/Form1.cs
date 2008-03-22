using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DeepWeb;

namespace DeepGoogle
{
    /**
     * Class Name       :   frmOne
     * Author           :   Patrick Lismore
     * Date             :   21/March/2008
     **/
    public partial class frmOne : Form
    {
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
            
            //**************************************
            //assign search query to String variable
            String query = txtSearch.Text;
            //**************************************
            //create string variables 
            String SearchType = "";
            String Full;
            //create an object from the DeepWeb Dll
            DeepWeb.Search ds = new Search();
            //**************************************

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
                }                }
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
               
                // resets the search text box back to blank
                txtSearch.Text = "";

                // passes the users search query & the SearchTypes
                // to the DeepWeb DLL which will build the DeepSearch
                // Goolge query
                Full = ds.DeepSearch(query, SearchType);

                // The web browser is told to go to google and query 
                // with some advanced operators and the users query and
                // the file type
                webBrowser1.Navigate(Full, false);
                SearchType = "";
           }
            
        }



        
    }