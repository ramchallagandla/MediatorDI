namespace MediatorDI
{
    public class Mediator : IMediator
    {
        public TResponse Process<TResponse>(IRequest<TResponse> req)
        {
            var requestHandlerType = typeof(IRequestHandler<,>).MakeGenericType(req.GetType(), typeof(TResponse));
            var handler = (IRequestHandler<TResponse>)Ioc.Container.GetInstance(requestHandlerType);
            
            return handler.Handle(req);
            
        }
    }
}
