using System.Diagnostics.CodeAnalysis;

namespace MyKeyBox.Shared.Abstractions.Shared;

public class Result
{
    protected internal Result(bool isSuccess, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }
    public bool IsSuccess { get; init; }
    public bool IsFailure => !IsSuccess;
    public bool IsNoContent => !IsSuccess;
    public Error Error { get; }
    
    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);
    
    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);

    public static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);

    public static Result<TValue> NoContent<TValue>(Error error) =>new (default,false, error);
    public static Result NoContent() => new(false, Error.None);
    
    public static Result<TValue> Create<TValue>(TValue? value) =>
        value is not null ? Success(value) : Failure<TValue>(Error.NullValue);
}

public class Result<TValue>:Result
{
    private readonly TValue _value;
    protected internal Result(TValue value ,bool isSuccess, Error error) : base(isSuccess, error)
    { _value = value; }
    
    [NotNull]
    public TValue Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("The value of a failure result can not be accessed.");

    public static Result<TValue> ConvertToMe(TValue? value)=>Create(value);
}

public record Error(string Status, int StatusCode)
{
    public static Error None = new Error(string.Empty, 0);
    
    public static Error NullValue = new Error("Bad Request", 400);
}
