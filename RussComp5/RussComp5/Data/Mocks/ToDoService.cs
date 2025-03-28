using Hackerspace.Shared.Interfaces;

using Hackerspace.Shared.Models;


namespace RussComp5.Data.Mocks
{
    public class ToDoService : IToDoService
    {
        public List<ToDo> GetAll()
        {
            return new List<ToDo>
            {
                new ToDo { Id = 1, Title = "Sample Task", Description = "This is a test",
                    CreateDate = DateTime.Now, Complete = false, CloseDate=DateTime.Now,//might want to change CloseDate=DateTime
                    Notes="No notes created yet"
                }
            };
        }

        //public List<ToDo> GetAllSync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
