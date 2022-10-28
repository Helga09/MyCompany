using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Repositories.Abstract;
namespace MyCompany.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public INewsRepository News { get; set; }
        public IMessagesRepository Messages { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository,
            IServiceItemsRepository serviceItemsRepository, INewsRepository newsRepository,
            IMessagesRepository messagesRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            News = newsRepository;
            Messages = messagesRepository;

        }
    }
}
