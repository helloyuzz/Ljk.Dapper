using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowDoubleConfirmAuthorization",Remarks="")]
   public class TFlowDoubleConfirmAuthorization {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="FlowID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowID {
          get;
          set;
      }
      [LjkDapperField(Name="Remark",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string Remark {
          get;
          set;
      }
      [LjkDapperField(Name="ActionID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ActionID {
          get;
          set;
      }
      [LjkDapperField(Name="RefID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? RefID {
          get;
          set;
      }
      [LjkDapperField(Name="ActionContent",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=1000)]
      public virtual string ActionContent {
          get;
          set;
      }
      [LjkDapperField(Name="AuthorizedBy",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? AuthorizedBy {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedTime",SqlDbType=SqlDbType.DateTime,AllowDBNull =false,MaxLength=16)]
      public virtual DateTime? CreatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="UpdatedTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? UpdatedTime {
          get;
          set;
      }
      [LjkDapperField(Name="CreatedBy",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
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
      [LjkDapperField(Name="FlowType",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? FlowType {
          get;
          set;
      }
   }
}