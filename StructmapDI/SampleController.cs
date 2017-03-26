using MediatorDI;
using System;

namespace StructmapDI
{
    public class SampleController
    {
        private IMediator _mediator;
        public SampleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void DoSomething(DoSomethingReq req)
        {
            Console.WriteLine(_mediator.Process(req));
        }
    }
}
