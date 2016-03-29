using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilderLibrary
{
  public  class XmlMarkupBuilder
    {
         string Tag { get; set; }
       static  StringBuilder Sb { get; set; }

      public  XmlMarkupBuilder openTag(String tagName) {
           Sb.Append("<");
            Sb.Append(tagName);
            Sb.Append(">");
            Console.WriteLine(Sb.ToString());
            return this ;
        }

        bool IsTagOpen(String sb) {
            if (sb.StartsWith("</") && sb.EndsWith(">"))
                return false;
            else if (sb.StartsWith("<") && sb.EndsWith(">"))
                return true;
            else return false;
        }
        XmlMarkupBuilder addAttr(String attrName, String attrValue)
        {
            if (IsTagOpen(this.ToString()))
            {
                Sb.Append( " " + attrName + "=\"" + attrValue + "\"");
                return this;
            }
            else throw new NotOpenTagException();
        }

        XmlMarkupBuilder addText(String text) {
            Sb.Append(text);
            return this;
        }
        XmlMarkupBuilder closeTag() {
            for (int i = Sb.Length; i >=0; i--)
            {
               
            }
            return this;
        }
    }
}
