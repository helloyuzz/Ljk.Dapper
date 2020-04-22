using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowStayRecycle",Remarks="")]
   public class TFlowStayRecycle {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="BarCode",SqlDbType=SqlDbType.NVarChar,AllowDBNull =false,MaxLength=100)]
      public virtual string BarCode {
          get;
          set;
      }
      [LjkDapperField(Name="OperateTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? OperateTime {
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
      [LjkDapperField(Name="RegisterOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RegisterOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="StayRecycleUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? StayRecycleUserID {
          get;
          set;
      }
      [LjkDapperField(Name="StayRecycleTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? StayRecycleTime {
          get;
          set;
      }
      [LjkDapperField(Name="RecycleOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? RecycleOrgID {
          get;
          set;
      }
      [LjkDapperField(Name="ApplyOrgID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ApplyOrgID {
          get;
          set;
      }
   }
}