using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MeuSite2.Models;

public partial class CustomerMovements
{

    public readonly Context _context;

    public CustomerMovements(Context context)
    {
        _context = context;
    }

    [Key]
     
    public Guid? Id { get; set; }

    public DateTime? MovementDate { get; set; }

    public decimal? Value { get; set; }

    public string? Document { get; set; }

    public string? CardNumber { get; set; }

    public string? MovementTime { get; set; }

    public string? StoreOwnerName { get; set; }

    public string? StoreName { get; set; }

    public int? TransactionTypeId { get; set; }



    public CustomerMovements()
    {

    }



    public List<CustomerMovements> BuscarTodos()
    {
        return _context.customerMovements.ToList();
    }


    public void Insert(CustomerMovements obj)
    {
        _context.Add(obj);
        _context.SaveChanges();
    }


    public CustomerMovements Delete (Guid id) 
    {
        return _context.customerMovements.FirstOrDefault(Obj=>Obj.Id==id);
    }


    public void Remove(Guid id)
    {
        var obj = _context.customerMovements.Find(id);
        _context.customerMovements.Remove(obj);
        _context.SaveChanges();
    }

}



