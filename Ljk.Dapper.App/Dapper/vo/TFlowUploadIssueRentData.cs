using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowUploadIssueRentData",Remarks="")]
   public class TFlowUploadIssueRentData {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="BatchID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? BatchID {
          get;
          set;
      }
      [LjkDapperField(Name="IssueID",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string IssueID {
          get;
          set;
      }
      [LjkDapperField(Name="LatestFlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? LatestFlowID {
          get;
          set;
      }
      [LjkDapperField(Name="ProductID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ProductID {
          get;
          set;
      }
      [LjkDapperField(Name="RentQuantity",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RentQuantity {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? UpdatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string CreatedBy {
          get;
          set;
      }
      [LjkDapperField(Name="UpdatedBy",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string UpdatedBy {
          get;
          set;
      }
      [LjkDapperField(Name="IsDeleted",SqlDbType=SqlDbType.Bit,AllowDBNull =false,MaxLength=1)]
      public virtual bool? IsDeleted {
          get;
          set;
      }
      [LjkDapperField(Name="IsUpload",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? IsUpload {
          get;
          set;
      }
   }
}