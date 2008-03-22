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
         *                      as a string for web browser control to
         *                      use
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


    }
}
