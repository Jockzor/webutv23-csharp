
using _00_Repetition.Interfaces;
using _00_Repetition.Models;

namespace _00_Repetition.Services;

internal class TodoService : ITodoService
{
    private readonly List<Todo> _todoList = new List<Todo>();    
    public void AddTodoToList(Todo todo)
    {
        _todoList.Add(todo); 
    }

    public void Delete(Guid id)
    {
        var todo = _todoList.FirstOrDefault(x => x.Id == id);   
        if(todo != null) 
            _todoList.Remove(todo);
    }

    public IEnumerable<Todo> GetAll()
    {
        return _todoList.OrderByDescending(todo=> todo.Created);
    }
}
