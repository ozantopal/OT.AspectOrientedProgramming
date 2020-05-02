using OT.AspectOrientedProgramming.Business.Abstracts;
using OT.AspectOrientedProgramming.CrossCutting.Aspects;

namespace OT.AspectOrientedProgramming.Business.Concretes
{
    public class FooService : IFooService
    {
        [LoggingAspect]
        public void Foo()
        {

        }

        [LoggingAspect]
        public void Do()
        {

        }

        [LoggingAspect]
        public void Bar()
        {
            throw new System.NotImplementedException();
        }
    }
}
