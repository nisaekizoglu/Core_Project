using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessages(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessages(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }
        public List<WriterMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
