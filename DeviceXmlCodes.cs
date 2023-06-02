using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKLibrary
{
    public class DeviceXmlCodes
    {

        #if KullanımlarıVeXML
    
            Program silen xml verisi;

            <?xml version="1.0" encoding="utf-8"?>
            <sdk guid="##GUID">
                <in method="DeleteProgram">
                <program type="normal" id="0" guid="##ProgramGuid" name="">
                    <backgroundMusic />
                    <playControl count="1" disabled="false" />
                </program>
                </in>
            </sdk>



            dosya silen xml verisi;

            <?xml version="1.0" encoding="utf-8"?>
            <sdk  guid="##GUID">
                <in  method="DeleteFiles">
                    <files>
                        <file  name="##DosyaAdı"/>
                    </files>
                </in>
            </sdk>

        #endif


        public static string DeleteProgram(string guid)
        {
            string XmlData = $@"
                <?xml version=""1.0"" encoding=""utf-8""?>
                <sdk guid=""##GUID"">
                  <in method=""DeleteProgram"">
                    <program type=""normal"" id=""0"" guid=""{guid}"" name="""">
                      <backgroundMusic />
                      <playControl count=""1"" disabled=""false"" />
                    </program>
                  </in>
                </sdk>
            ";

            //Aşağıda ki gibi de silinebilir.
            /*
             <?xml version = "1.0" encoding = "utf-8" ?>
            <sdk guid = "##GUID">
                <in method = "DeleteProgram" >
		            <area guid="{guid}"/>
                </in>
            </sdk>
             */

            return XmlData.Trim();
        }


        public static string DeleteFile(string file_name)
        {
            string XmlData = $@"
                <?xml version=""1.0"" encoding=""utf-8""?>
                <sdk  guid=""##GUID"">
                    <in  method=""DeleteFiles"">
                        <files>
                            <file name=""{file_name}""/>
                        </files>
                    </in>
                </sdk>
            ";

            //Aşağıda ki gibi dosyanın md5 değerini verip de silebiliriz.
            /*
                <?xml version="1.0"?>
                <sdk guid="##GUID">
                    <in method="DeleteFiles">
                        <files>
                            <file md5="bc9cfab2fd207d32a51e913669985d1e"/>
                        </files>
                    </in>
                </sdk>
             */

            return XmlData.Trim();
        }


        public static string GetCurrentPlayProgramGUID()
        {
            //string xml = @"
            //    <?xml version='1.0' encoding='utf-8'?>
            //    <sdk guid=""##GUID"">
            //        <in method=""GetCurrentPlayProgramGUID""/>
            //    </sdk>
            //";     

            string xml = @"
               <?xml version='1.0' encoding='utf-8'?>
                <sdk guid=""Deva software is the best"">
                    <in method=""GetCurrentPlayProgramGUID""/>
                </sdk>
            ";

            return xml.Trim();
        }

    }
}
