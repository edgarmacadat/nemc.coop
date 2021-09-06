using NEMC.BL.Interface;
using NEMC.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEMC.BL
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private bool isDisposed;

        public UnitOfWork(string connectionString = null) {
            this._context = new ApplicationDbContext(connectionString);
            this.MembershipBusinessLogic = new MembershipBusinessLogic(this._context);
        }
        public IMembershipBusinessLogic MembershipBusinessLogic { get; private set; }

        #region Base
        public void Complete() {
            this._context.SaveChanges();
        }

        public void Dispose() {
            this.dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing) {
            if (!this.isDisposed) {
                if (disposing) {
                    if (this._context != null) {
                        this._context.Dispose();
                        this._context = null;
                    }
                }
            }
            this.isDisposed = true;
        }

        ~UnitOfWork() {
            dispose(false);
        }
        #endregion
    }
}
