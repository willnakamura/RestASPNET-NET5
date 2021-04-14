using System.Collections.Generic;

namespace RestASPNET_NET5.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
