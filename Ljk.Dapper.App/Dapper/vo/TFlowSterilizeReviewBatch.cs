using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TFlowSterilizeReviewBatch",Remarks="")]
   public class TFlowSterilizeReviewBatch {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="SterilizeBatchID",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? SterilizeBatchID {
          get;
          set;
      }
      [LjkDapperField(Name="ChemistryReviewUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ChemistryReviewUserID {
          get;
          set;
      }
      [LjkDapperField(Name="ChemistryReviewState",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ChemistryReviewState {
          get;
          set;
      }
      [LjkDapperField(Name="ChemistryReviewTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? ChemistryReviewTime {
          get;
          set;
      }
      [LjkDapperField(Name="ChemistryReviewUnqualifiedID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? ChemistryReviewUnqualifiedID {
          get;
          set;
      }
      [LjkDapperField(Name="ChemistryReviewRemark",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string ChemistryReviewRemark {
          get;
          set;
      }
      [LjkDapperField(Name="BiologyReviewUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? BiologyReviewUserID {
          get;
          set;
      }
      [LjkDapperField(Name="BiologyReviewState",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? BiologyReviewState {
          get;
          set;
      }
      [LjkDapperField(Name="BiologyReviewTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? BiologyReviewTime {
          get;
          set;
      }
      [LjkDapperField(Name="BiologyReviewUnqualifiedID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? BiologyReviewUnqualifiedID {
          get;
          set;
      }
      [LjkDapperField(Name="BiologyReviewRemark",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string BiologyReviewRemark {
          get;
          set;
      }
      [LjkDapperField(Name="PhysicalReviewUserID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PhysicalReviewUserID {
          get;
          set;
      }
      [LjkDapperField(Name="PhysicalReviewState",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PhysicalReviewState {
          get;
          set;
      }
      [LjkDapperField(Name="PhysicalReviewTime",SqlDbType=SqlDbType.DateTime,MaxLength=16)]
      public virtual DateTime? PhysicalReviewTime {
          get;
          set;
      }
      [LjkDapperField(Name="PhysicalReviewUnqualifiedID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PhysicalReviewUnqualifiedID {
          get;
          set;
      }
      [LjkDapperField(Name="PhysicalReviewRemark",SqlDbType=SqlDbType.NText,MaxLength=2147483646)]
      public virtual string PhysicalReviewRemark {
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
      [LjkDapperField(Name="ComputedReviewResult",SqlDbType=SqlDbType.Int,AllowDBNull =false,MaxLength=4)]
      public virtual int? ComputedReviewResult {
          get;
          set;
      }
   }
}