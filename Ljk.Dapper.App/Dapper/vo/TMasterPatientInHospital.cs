using System;
using Ljk.Dapper;
using System.Data;

namespace CSSD.Web.API.Dapper.vo {
   [Serializable]
   [LjkDapperField(Name="TMasterPatientInHospital",Remarks="")]
   public class TMasterPatientInHospital {
      [LjkDapperField(Name="ID",SqlDbType=SqlDbType.Int,IsPrimaryKey = true,KEY_SEQ=1,AllowDBNull =false,MaxLength=4)]
      public virtual int? ID {
          get;
          set;
      }
      [LjkDapperField(Name="PatientID",SqlDbType=SqlDbType.Int,MaxLength=4)]
      public virtual int? PatientID {
          get;
          set;
      }
      [LjkDapperField(Name="InPatientCode",SqlDbType=SqlDbType.NVarChar,MaxLength=72)]
      public virtual string InPatientCode {
          get;
          set;
      }
      [LjkDapperField(Name="WardArea",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string WardArea {
          get;
          set;
      }
      [LjkDapperField(Name="BedNumber",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string BedNumber {
          get;
          set;
      }
      [LjkDapperField(Name="BedNurse",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string BedNurse {
          get;
          set;
      }
      [LjkDapperField(Name="InHospitalFlag",SqlDbType=SqlDbType.NVarChar,MaxLength=100)]
      public virtual string InHospitalFlag {
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
   }
}