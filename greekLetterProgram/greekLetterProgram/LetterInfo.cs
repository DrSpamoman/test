using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greekLetterProgram
{
    class LetterInfo
    {
        private string upperCasePictureLink;
        private string lowerCasePictureLink;
        private string letterName;

        public void SetInfo(string upperCaseLink, string lowerCaseLink, string name)
        {
            upperCasePictureLink = upperCaseLink;
            lowerCasePictureLink = lowerCaseLink;
            letterName = name;
        }

        public string UpperCase
        {
            get { return upperCasePictureLink; }
            set { upperCasePictureLink = value; }
        }
        public string LowerCase
        {
            get { return lowerCasePictureLink; }
            set { lowerCasePictureLink = value; }
        }
        public string LetterName
        {
            get { return letterName; }
            set { letterName = value; }
        }

    }
}
