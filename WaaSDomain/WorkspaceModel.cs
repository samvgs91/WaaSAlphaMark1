using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WaaSDataAccess;

namespace WaaSDomain
{
    public class WorkspaceModel
    {
        FileSto fileSto = new FileSto();
        FileDao fileDao = new FileDao();



    public bool AddFile(string fileName, string destinyPath,string subDestinyPath, string sourcePath,string size)
        {
            string accountName = fileSto.GetAccount();
            string containerName = fileSto.GetContainer();
            string userId = destinyPath;
            string path = containerName + "/" + userId;


            //   workspaceModel.AddFile(fileName, "abcId","TableDemoDW", filePath, "waas-data");
            bool fileDaoBool = fileDao.InsertFile(userId, fileName, accountName, containerName, path, size);
            bool fileStoBool = fileSto.AddFile(fileName, destinyPath, subDestinyPath, sourcePath, containerName);

            if (fileDaoBool && fileStoBool)
                return true;
            else
                return false;
        }

        public bool DeleteFile(string fileName, string destinyPath, string sourcePath, string container)
        {
            return fileSto.DeleteFile(fileName, destinyPath, sourcePath, container);
        }
    }
}
