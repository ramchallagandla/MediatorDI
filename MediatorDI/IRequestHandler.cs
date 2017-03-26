namespace MediatorDI
{
    //Check C# Generics Covariance and Contravariance. 
    //In the Mediator.cs class after the IOC created the instance it is of type Object. We need to cast it to
    //IRequestHandler<TRequest, TResponse>. This is not valid in c#. Since we don't have the TRequest. Mediator.Process class has only TResponse.
    //So create an interface with only TResponse and implement in the second interface below.
    //We need abstract class to implement base interface handler IRequestHandler<TResponse>.Handle
    public interface IRequestHandler<out TResponse>
    {
        TResponse Handle(object request);
    }
    //Handler with response
    public interface IRequestHandler<in TRequest, out TResponse>: IRequestHandler<TResponse> where TRequest: IRequest<TResponse>
    {
        TResponse Handle(TRequest request);
    }

    public abstract class BaseRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        public abstract TResponse Handle(TRequest request);

        TResponse IRequestHandler<TResponse>.Handle(object request)
        {
            return this.Handle((TRequest)request);
        }
    }
}
