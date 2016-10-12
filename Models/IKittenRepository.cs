using System.Collections.Generic;

namespace CfSampleAppDotNet.Models
{
    public interface IKittenRepository
    {
        Kitten Create(Kitten kitten);
        IEnumerable<Kitten> Find();
    }
}
