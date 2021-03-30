using System;
using System.Windows.Forms;
using mshtml;

namespace ExtendedWebBrowser2
{
    public class Adblock
    {
        internal static void Filter(HTMLDocument document)
        {
            foreach (IHTMLImgElement image in document.images)
                Remove(image as IHTMLDOMNode);

            foreach (IHTMLEmbedElement embed in document.embeds)
                Remove(embed as IHTMLDOMNode);

            foreach (IHTMLElement2 htmlElement2 in document.getElementsByTagName("OBJECT"))
            {
                foreach (IHTMLElement4 htmlElement4 in htmlElement2.getElementsByTagName("PARAM"))
                {
                    var attr = (string)htmlElement4.getAttributeNode("NAME").nodeValue;
                    if ("Src".Equals(attr, StringComparison.CurrentCultureIgnoreCase) 
                        || "Movie".Equals(attr, StringComparison.CurrentCultureIgnoreCase))
                        Remove(htmlElement2 as IHTMLDOMNode);
                }
            }
            foreach (IHTMLElement4 htmlElement4 in document.getElementsByTagName("IFRAME"))
                Remove(htmlElement4 as IHTMLDOMNode);
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
