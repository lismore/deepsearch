using System;
using System.Collections.Generic;
using System.Text;

namespace DeepWeb
{
    /**
     * Class Name       :   Search
     * Author           :   Patrick Lismore
     * Date             :   21/March/2008
     * Discription      :   DLL for the DeepSearch Application
     *                      queries and file types to be search
     *                      are passed over and then url's are 
     *                      built and sent back to the web browser
     *                      control
     *                      The DLL has other ultility functions aswell
     * */
    public class Search
    {
        /**
         *Method Name       :   DeepSearch
         *Discription       :   This method will take the users search
         *                      query and file types to search for and
         *                      build up a URL so that I can pass back 
         *                      as a string for the web browser control
         *                      to use
         * Parameters       :   query,  SearchType
         * 
         **/
        public String DeepSearch(String query , String SearchType){

            //declare a local string variable to hold the URL
            String Full;
            
            //Charachter array that holds the charachter that i want
            // removed from the SearchType
            char[] trim = new char[] { '|' };

            // this statement trims the charachter thats in my charachter array
            // from the start for the SearchType string
            SearchType = SearchType.TrimStart(trim[0]);

            //The URL concatenated with the SearchType and Query
            Full = "http://www.google.com/search?hl=en&q=-inurl%3A%28htm%7Chtml%7Cphp%29+intitle%3A%22index+of%22+%2B%22last+modified%22+%2B%22parent+directory%22+%2Bdescription+%2Bsize+%2B%28" + SearchType + "%29+%22" + query + "%22";
		 
            // return the URL 
            return Full;
        }


        /**
         * Method Name      :   DeepTool
         * Discription      :   This method will pass back specific
         *                      url with users query based on which option
         *                      is choosen by the uesr
         * Parameters       :   query, tool
         * 
         * */
        public string DeepTool(string query, int tool)
        {
            String URL = "";

            //links
            if (tool == 1)
            {
                URL = "http://www.google.com/search?q=link%3A" + query;
            }
            else if (tool == 2)
            {   
                //add site to google
                URL = "http://www.google.com/addurl?q=" + query + "&hl=en&dqq=";
            }
            else if (tool == 3)
            {
                //related to
                URL = "http://www.google.com/search?q=related%3A" + query;
            }
            else if (tool == 4)
            {
                //search site
                URL = "http://www.google.com/search?q=site%3A" + query;
            }
            return URL;
        }
        
        /**
         * Method Name      :   DeepAdmin
         * Discription      :   This method will return a specific
         *                      url based on the users choice
         * Parameters       :   query, tool
         * 
         * */
        public string DeepAdmin(string query, int tool)
        {
            String URL = "";

            //auth_user_file
            if (tool == 1)
            {
                URL = "http://www.google.com/search?hl=en&q=allinurl%3Aauth_user_file.txt" + query;
            }
            else if (tool == 2)
            {
                //config.php files
                URL = "http://www.google.com/search?q=intitle%3A%22Index+of%22+config.php" + query;
            }
            else if (tool == 3)
            {
                //password lists
                URL = "http://www.google.com/search?q=inurl%3Apasslist.txt&btnG=Search" + query;
            }
            else if (tool == 4)
            {
                //passwords on the web
                URL = "http://www.google.com/search?q=intitle%3A%22Index+of%22+passwords+modified" + query;
            }
            return URL;
            
        }

        /**
         * Method Name  :   DeepTorrent
         * Discription  :   This method will return a url that will search
         *                  for a torrent based on the users query
         * Parameters   :   query
         * 
         **/
        public string DeepTorrent(string query)
        {
            String URL ="";

            //torrent url 
            URL = "http://www.google.com/search?q=" + query + "&btnG=Search&q=filetype%3Atorrent ";
            
            return URL;

        }

        /**
         * Method Name      :   DeepFonts
         * Discription      :   This method will return a url that will
         *                      dig for fonts based on the users query
         * Parameters       :   query
         * 
         **/
        public string DeepFonts(string query)
        {
            String URL = "";

            // fonts url
            URL = "http://www.google.com/search?q=site%3Ahttp%3A%2F%2Fwww.searchfreefonts.com " + query;
            
            return URL;
        }

        /**
         * Method Name      :   DeepLyrics
         * Discription      :   This method digs for lyrics of songs from
         *                      lyrics.com
         * Parameters       :   query
         * 
         **/
        public string DeepLyrics(string query)
        {
            String URL = "";

            //lyrics url
            URL = "http://www.google.com/search?q=site%3Awww.lyrics.com " + query;
            
            return URL;
        }

        /**
         * Method Name      :   DeepTranslate
         * Discription      :   This method will return a url that  
         *                      will query Googles Translate Dictionary
         *                      and will convert words from English to German
         *                      more languages to come
         * Parameters       :   query , lang
         * 
         * 
         **/
        public string DeepTranslate(string query, string lang)
        {
            String URL = "";
            
            //Translate URL
            URL = "http://translate.google.com/translate_dict?q="+query+"&hl=en&langpair=en%7Cde";
            return URL;
        }

        /**
         * Method Name      :   DeepMap
         * Discription      :   This method will retun a url that will
         *                      show the user  a map of the town or city queryed
         * Parameters       :   query
         **/
        public string DeepMap(string query)
        {
            String URL = "";

            URL = "http://maps.google.com/maps?hl=en&q="+query+"&um=1&ie=UTF-8&sa=N&tab=wl";
            return URL;
        }
    }
}
