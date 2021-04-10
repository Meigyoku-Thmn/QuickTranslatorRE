using System;
using System.Windows.Forms;
using mshtml;

using static System.StringComparison;

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

            foreach (IHTMLElement2 objectElm in document.getElementsByTagName("OBJECT"))
            {
                foreach (IHTMLElement4 paramElm in objectElm.getElementsByTagName("PARAM"))
                {
                    var attr = (string)paramElm.getAttributeNode("NAME").nodeValue;
                    if ("Src".Equals(attr, CurrentCultureIgnoreCase) || "Movie".Equals(attr, CurrentCultureIgnoreCase))
                        Remove(objectElm as IHTMLDOMNode);
                }
            }

            foreach (IHTMLElement4 htmlElement4 in document.getElementsByTagName("IFRAME"))
                Remove(htmlElement4 as IHTMLDOMNode);
        }

        private static void Remove(IHTMLDOMNode node)
        {
            try { node.parentNode.removeChild(node); }
            catch { }
        }
    }
}
