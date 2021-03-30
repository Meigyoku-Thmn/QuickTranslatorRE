using System;
using System.Windows.Forms;
using MSHTML;

namespace ExtendedWebBrowser2
{
    public class Adblock
    {
        internal static void Filter(HTMLDocument document)
        {
            foreach (object obj in document.images)
            {
                IHTMLImgElement ihtmlimgElement = (IHTMLImgElement)obj;
                Remove(ihtmlimgElement as IHTMLDOMNode);
            }
            foreach (object obj2 in document.embeds)
            {
                IHTMLEmbedElement ihtmlembedElement = (IHTMLEmbedElement)obj2;
                Remove(ihtmlembedElement as IHTMLDOMNode);
            }
            foreach (object obj3 in document.getElementsByTagName("OBJECT"))
            {
                IHTMLElement2 ihtmlelement = (IHTMLElement2)obj3;
                foreach (object obj4 in ihtmlelement.getElementsByTagName("PARAM"))
                {
                    IHTMLElement4 ihtmlelement2 = (IHTMLElement4)obj4;
                    if ("Src".Equals((string)ihtmlelement2.getAttributeNode("NAME").nodeValue, StringComparison.CurrentCultureIgnoreCase)
                        || "Movie".Equals((string)ihtmlelement2.getAttributeNode("NAME").nodeValue, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Remove(ihtmlelement as IHTMLDOMNode);
                    }
                }
            }
            foreach (object obj5 in document.getElementsByTagName("IFRAME"))
            {
                IHTMLElement4 ihtmlelement3 = (IHTMLElement4)obj5;
                Remove(ihtmlelement3 as IHTMLDOMNode);
            }
        }

        private static void Remove(IHTMLDOMNode node)
        {
            try
            {
                node.parentNode.removeChild(node);
            }
            catch
            {
            }
        }
    }
}
