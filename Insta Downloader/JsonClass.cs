using System.Collections.Generic;


namespace Insta_Downloader
{


     partial class Form1
    {
        class Node
        {
            public string __typename { get; set; }
            public string video_url { get; set; }
            public string display_url { get; set; }
        }
        class Edges
        {
            public Node node { get; set; }
        }
        class EdgeSidecarToChildren
        {
            public List<Edges> edges { get; set; }
        }
        class ShortcodeMedia
        {
            public string __typename { get; set; }

            public string display_url { get; set; }
            public string video_url { get; set; }
            public EdgeSidecarToChildren edge_sidecar_to_children { get; set; }

        }
        class Graphql
        {
            public ShortcodeMedia shortcode_media { get; set; }

        }
        class Root
        {
            public Graphql graphql { get; set; }

        }

        
    }
}

