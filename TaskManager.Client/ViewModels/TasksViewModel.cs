using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Client.ViewModels.Base;
using TaskManager.Common.Dtos;

namespace TaskManager.Client.ViewModels
{
    public class TasksViewModel : ViewModelBase
    {
        private ObservableCollection<TaskDto> tasks;
        public ObservableCollection<TaskDto> Tasks { get => tasks; set => Set(ref tasks, value); }

        public static TaskDto staticCurrentEditTask;

        private TaskDto currentEditTask;
        public TaskDto CurrentEditTask { get => currentEditTask; set => Set(ref currentEditTask, value); }

        public TasksViewModel()
        {
            CurrentEditTask = staticCurrentEditTask;

            using (HttpClient client = new())
            {
                var response = client.GetAsync("http://localhost:5000/api/task").Result.Content.ReadAsStringAsync().Result;
                var tasksDtos = JsonConvert.DeserializeObject<IEnumerable<TaskDto>>(response);
                Tasks = new ObservableCollection<TaskDto>(tasksDtos);
            }
        }

        public void SaveCurrentEditTask()
        {
            using (HttpClient client = new())
            {
                var dtoStr = JsonConvert.SerializeObject(CurrentEditTask);
                var content = new StringContent(dtoStr, Encoding.UTF8, "application/json");
                _ = client.PatchAsync($"http://localhost:5000/api/task", content);
            }
        }

        public void DeleteCurrentEditTask()
        {
            using (HttpClient client = new())
            {
                _ = client.DeleteAsync($"http://localhost:5000/api/task/{currentEditTask.Id}").Result;
            }
        }
    }
}
