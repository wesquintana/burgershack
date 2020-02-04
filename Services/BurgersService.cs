using System;
using System.Collections.Generic;
using burgershackapi.Models;
using burgershackapi.Repositories;

namespace burgershackapi.Services
{
  public class BurgersService
  {
    private readonly BurgersRepository _repo;
    public BurgersService(BurgersRepository br)
    {
      _repo = br;
    }
    public IEnumerable<Burger> Get()
    {
      return _repo.Get();
    }
    internal Burger GetById(int id)
    {
      var exists = _repo.getById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }
    internal Burger Create(Burger newData)
    {
      return _repo.Create(newData);
    }
    internal Burger Update(Burger update)
    {
      var exists = _repo.getById(update.Id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Edit(update);
      return update;
    }
    internal string Delete(int id)
    {
      var exists = _repo.getById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Delete(id);
      return "Successfully Deleted";
    }
  }
}