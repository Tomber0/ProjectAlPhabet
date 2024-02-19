using ProjectAlPhabet.Model;
using ProjectAlPhabet.Utils;

namespace ProjectAlPhabet.Api
{
    static class CoreApi
    {
        
        //should return an Image url
        //get info from config file: url, black list, tags, pririty tags
        static public void FindImage()//skip for now
        {
            //main method

            /* simple cycle:
             * 1)go to uri 
             * 2)find image on lsit
             * 3)open it
             * 4)save it
             */

        }

        //priority 1
        static public void PostImage(PictureInfo pictureInfo)//implement 
        {
            
        }

        //gets an Image collection and performs an analyse
        static public void ChooseImage() 
        {
            
        }

        //should return a ImageInfo form url -> from FindImage()
        //private?
        static public void FetchImage() 
        {
            
        }

        static public void UpdateConfig(string configFile)//in: config
        {
            if (!CoreUtils.IsInitialFilePresented()) 
            {
                CoreUtils.CreateIniFile();
            }
            CoreUtils.ReadIniFile();
        }

        //priority 99
        static public bool UpdateTokenConfig(string configFile)//in: config
        {

            return false;
        }


        //create an API
        //?
        //1 find an Image
        
        //2 Set confings

        //21 get conf file 

        //22 aply conf file

    }
}
