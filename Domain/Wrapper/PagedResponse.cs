using System.Net;

namespace Domain.Wrapper;

public class PagedResponse<T>: Response<T>
{
    public PagedResponse(T data) : base(data)
    {
    }

    public PagedResponse(HttpStatusCode statusCode, List<string> errors) : base(statusCode, errors)
    {
    }
    
    public PagedResponse(T data,int totalRecords, int pageNumber, int pageSize):base(data)
    {
        TotalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
        PageNumber = pageNumber;
        TotalRecords = totalRecords;
        PageSize = pageSize;
    }

    public int PageNumber { get; set; }
    public int TotalPages { get; set; }
    public int TotalRecords { get; set; }
    public int PageSize { get; set; }
}