using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrWill
{
    class DocProcessor
    {
        public void ProcessDoc(ParamsContainer parsCntr)
        {
            string curDir = Directory.GetCurrentDirectory();
            var flname = curDir + "\\" + "Programmable Will.docx";
            var nameStr = "NAME";
            var altNameStr = "ALTERNATE_" + parsCntr.sName;
            var altNameRemStr = "also known as ALTERNATE_" + parsCntr.sName + ",";
            var countyStr = "COUNTY";
            var spouseStr = "SPOUSE";
            var spouseRem = "I am presently married and the name of my spouse is SPOUSE.";
            var notMarriedStr = "I am presently not married.";

            //+ ",";
            //parsCntr.

            //Create a new microsoft word file
            Microsoft.Office.Interop.Word.Application fileOpen = new Microsoft.Office.Interop.Word.Application();
            //Open a already existing word file into the new document created
            Microsoft.Office.Interop.Word.Document document = fileOpen.Documents.Open(flname, ReadOnly: false);
            //Make the file visible 
            fileOpen.Visible = true;
            document.Activate();

            // Name
            FindAndReplace(fileOpen, nameStr, parsCntr.sName);

            // Alt. Name
            var remSpcAltName = Regex.Replace(parsCntr.sAltname, @"\s+", "");
            // Alt Name is empty
            if (remSpcAltName == "")
            {
                FindAndReplace(fileOpen, altNameRemStr, "");
            } else
                FindAndReplace(fileOpen, altNameStr, parsCntr.sAltname);

            // County
            FindAndReplace(fileOpen, countyStr, parsCntr.sCounty);

            // Spouse
            var remSpcSpouse = Regex.Replace(parsCntr.sSpouse, @"\s+", "");
            // Spouse is empty, doesn't have a spouse
            if (remSpcSpouse == "")
            {
                // remove spouse string
                FindAndReplace(fileOpen, spouseRem, "");
            }
            else
            {
                // insert spouse
                FindAndReplace(fileOpen, spouseStr, parsCntr.sSpouse);
                // remove not married str
                FindAndReplace(fileOpen, notMarriedStr, "");
            }

            // Children
            var more2ChildrenInsStr = "";
            for (int i = 0; i < parsCntr.sChildren.Count(); i++)
            {
                var childStr = "CHILD_" + (i + 1);
                var childBirthStr = childStr + "_BIRTHDATE";
                if (i < 2)
                {
                    FindAndReplace(fileOpen, childStr, parsCntr.sChildren[i].sName);
                    FindAndReplace(fileOpen, parsCntr.sChildren[i].sName + "_BIRTHDATE", parsCntr.sChildren[i].sDate);
                } else
                {
                    // more than 2 children
                    more2ChildrenInsStr += parsCntr.sChildren[i].sName + "              " + parsCntr.sChildren[i].sDate;
                    more2ChildrenInsStr += "\r";
                }
            }

            var moreChilderStr = "add more children";
            if (parsCntr.sChildren.Count() > 2)
                FindAndReplace(fileOpen, moreChilderStr, more2ChildrenInsStr);
            else
                FindAndReplace(fileOpen, moreChilderStr, "");

            // Name of Excluded Individual
            var remSpcNameExclInd = Regex.Replace(parsCntr.sNameExclIndiv, @"\s+", "");
            if (remSpcNameExclInd == "")
            {
                // remove
                var sect4 = "Section 4. Exclusion of Certain Individuals. I hereby acknowledge the existence of [name of excluded individual] and intentionally, with full knowledge, have chosen to exclude this person under the terms of my Will.";
                FindAndReplace(fileOpen, sect4, "");
            }
            else
            {
                var nameExculIndStr = "[name of excluded individual]";
                FindAndReplace(fileOpen, nameExculIndStr, parsCntr.sNameExclIndiv);
            }

            // Personal Representative
            var persnRepr1 = "PR_1";
            FindAndReplace(fileOpen, persnRepr1, parsCntr.sPersnRepr1);
            var persnRepr2 = "PR_2";
            FindAndReplace(fileOpen, persnRepr2, parsCntr.sPersnRepr2);
            var persnRepr3 = "PR_3";
            FindAndReplace(fileOpen, persnRepr3, parsCntr.sPersnRepr3);

            // Burial/Cremation
            if (parsCntr.bBurial)
            {
                var sCremationTxt = "I do hereby designate my Personal Representative to order the cremation of my human remains upon my death. I direct that my human remains be cremated, pursuant to Arizona Revised Statute 32-1365.01.";
                FindAndReplace(fileOpen, sCremationTxt, "");
            } else
            {
                var sBurialTxt  = "I do hereby designate my Personal Representative to order the burial of my human remains upon my death.";
                FindAndReplace(fileOpen, sBurialTxt, "");
            }

            // Date
            var dateStr = "DATE";
            FindAndReplace(fileOpen, dateStr, parsCntr.sDate);

            //Save the editted file in a specified location
            //Can use SaveAs instead of SaveAs2 and just give it a name to have it saved by default
            //to the documents folder
            document.SaveAs2(curDir + "\\" + "Programmable Will - Generated.docx");
        }

        static void FindAndReplace(Microsoft.Office.Interop.Word.Application fileOpen, object findText, object replaceWithText)
        {
            //object matchCase = false;            
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            fileOpen.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
    }
}
