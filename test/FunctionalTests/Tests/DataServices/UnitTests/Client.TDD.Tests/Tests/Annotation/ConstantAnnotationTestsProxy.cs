﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/16/2015 3:08:28 PM
namespace Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy
{
    /// <summary>
    /// There are no comments for ConstantAnnotationContainerPlus in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConstantAnnotationContainer")]
    public partial class ConstantAnnotationContainerPlus : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ConstantAnnotationContainerPlus object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public ConstantAnnotationContainerPlus(global::System.Uri serviceRoot) :
            base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected new global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "ConstantAnnotationService", "Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("ConstantAnnotationService.", originalNameAttribute.OriginalName);
                }
                return string.Concat("ConstantAnnotationService.", clientType.Name);
            }
            return null;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""ConstantAnnotationService"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <Term Name=""BinaryTerm"" Type=""Edm.Binary"" DefaultValue=""2345"" AppliesTo=""EntityType"" />
      <Term Name=""BooleanTerm"" Type=""Edm.Boolean"" DefaultValue=""true"" AppliesTo=""EntityType"" />
      <Term Name=""DateTerm"" Type=""Edm.Date"" DefaultValue=""2000-02-02"" AppliesTo=""EntityType"" />
      <Term Name=""DateTimeOffsetTerm"" Type=""Edm.DateTimeOffset"" DefaultValue=""2000-01-01T16:00:00.000-09:00"" AppliesTo=""EntityType"" />
      <Term Name=""DecimalTerm"" Type=""Edm.Decimal"" DefaultValue=""20"" AppliesTo=""EntityType"" />
      <Term Name=""DurationTerm"" Type=""Edm.Duration"" DefaultValue=""P1D23H59M59.1S"" AppliesTo=""EntityType"" />
      <Term Name=""EnumMemberHasFlagTerm"" Type=""ConstantAnnotationService.AccessLevel"" DefaultValue=""ConstantAnnotationService.AccessLevel/ReadWrite"" AppliesTo=""EntityType"" />
      <Term Name=""EnumMemberTerm"" Type=""ConstantAnnotationService.Color"" DefaultValue=""ConstantAnnotationService.Color/Red"" AppliesTo=""EntityType"" />
      <Term Name=""FloatTerm"" Type=""Edm.Single"" DefaultValue=""10.0"" AppliesTo=""EntityType"" />
      <Term Name=""GuidTerm"" Type=""Edm.Guid"" DefaultValue=""21EC2020-3AEA-1069-A2DD-08002B30309C"" AppliesTo=""EntityType"" />
      <Term Name=""Int32Term"" Type=""Edm.Int32"" DefaultValue=""20"" AppliesTo=""EntityType"" />
      <Term Name=""Int64Term"" Type=""Edm.Int64"" DefaultValue=""21"" AppliesTo=""EntityType"" />
      <Term Name=""StringTerm"" Type=""Edm.String"" DefaultValue="""" AppliesTo=""EntityType"" />
      <Term Name=""TimeOfDayTerm"" Type=""Edm.TimeOfDay"" DefaultValue=""01:01:01"" AppliesTo=""EntityType"" />
      <EnumType Name=""AccessLevel"" IsFlags=""true"">
        <Member Name=""Read"" Value=""1"" />
        <Member Name=""Write"" Value=""2"" />
        <Member Name=""ReadWrite"" Value=""3"" />
      </EnumType>
      <EnumType Name=""Color"">
        <Member Name=""Red"" Value=""0"" />
        <Member Name=""Yellow"" Value=""1"" />
        <Member Name=""Blue"" Value=""2"" />
      </EnumType>
      <EntityType Name=""ETForConstAsElement"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Annotation Term=""ConstantAnnotationService.BinaryTerm"">
          <Binary>1234</Binary>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.BooleanTerm"">
          <Bool>true</Bool>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.DateTerm"">
          <Date>2000-01-01</Date>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.DateTimeOffsetTerm"">
          <DateTimeOffset>2000-01-01T16:00:00.000Z</DateTimeOffset>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.DecimalTerm"">
          <Decimal>3.14</Decimal>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.DurationTerm"">
          <Duration>P11D23H59M59.999999999999S</Duration>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.FloatTerm"">
          <Float>2.2</Float>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.GuidTerm"">
          <Guid>21EC2020-3AEA-1069-A2DD-08002B30309D</Guid>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.Int32Term"">
          <Int>42</Int>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.Int64Term"">
          <Int>64</Int>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.StringTerm"">
          <String>test</String>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.TimeOfDayTerm"">
          <TimeOfDay>21:45:00</TimeOfDay>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.EnumMemberHasFlagTerm"">
          <EnumMember>ConstantAnnotationService.AccessLevel/Read</EnumMember>
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.EnumMemberTerm"">
          <EnumMember>ConstantAnnotationService.Color/Yellow</EnumMember>
        </Annotation>
      </EntityType>
      <EntityType Name=""ETForConstAsAttribute"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Annotation Term=""ConstantAnnotationService.BinaryTerm"" Binary=""1234"" />
        <Annotation Term=""ConstantAnnotationService.BooleanTerm"" Bool=""false"" />
        <Annotation Term=""ConstantAnnotationService.DateTerm"" Date=""2000-01-01"" />
        <Annotation Term=""ConstantAnnotationService.DateTimeOffsetTerm"" DateTimeOffset=""2000-01-01T16:00:00.000Z"" />
        <Annotation Term=""ConstantAnnotationService.DecimalTerm"" Decimal=""2.15"" />
        <Annotation Term=""ConstantAnnotationService.DurationTerm"" Duration=""P11D23H59M59.999999999999S"" />
        <Annotation Term=""ConstantAnnotationService.FloatTerm"" Float=""1.0"" />
        <Annotation Term=""ConstantAnnotationService.GuidTerm"" Guid=""21EC2020-3AEA-1069-A2DD-08002B30309E"" />
        <Annotation Term=""ConstantAnnotationService.Int32Term"" Int=""32"" />
        <Annotation Term=""ConstantAnnotationService.Int64Term"" Int=""33"" />
        <Annotation Term=""ConstantAnnotationService.StringTerm"" String=""test2"" />
        <Annotation Term=""ConstantAnnotationService.TimeOfDayTerm"" TimeOfDay=""20:45:00"" />
        <Annotation Term=""ConstantAnnotationService.EnumMemberHasFlagTerm"" EnumMember=""ConstantAnnotationService.AccessLevel/Read ConstantAnnotationService.AccessLevel/Write"" />
        <Annotation Term=""ConstantAnnotationService.EnumMemberTerm"" EnumMember=""ConstantAnnotationService.Color/Blue"" />
      </EntityType>
      <EntityType Name=""ETForConstWithDefaultValue"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Annotation Term=""ConstantAnnotationService.BinaryTerm"" />
        <Annotation Term=""ConstantAnnotationService.BooleanTerm"" />
        <Annotation Term=""ConstantAnnotationService.DateTerm"" />
        <Annotation Term=""ConstantAnnotationService.DateTimeOffsetTerm"" />
        <Annotation Term=""ConstantAnnotationService.DecimalTerm"" />
        <Annotation Term=""ConstantAnnotationService.DurationTerm"" />
        <Annotation Term=""ConstantAnnotationService.FloatTerm"" />
        <Annotation Term=""ConstantAnnotationService.GuidTerm"" />
        <Annotation Term=""ConstantAnnotationService.Int32Term"" />
        <Annotation Term=""ConstantAnnotationService.Int64Term"" />
        <Annotation Term=""ConstantAnnotationService.StringTerm"" />
        <Annotation Term=""ConstantAnnotationService.TimeOfDayTerm"" />
        <Annotation Term=""ConstantAnnotationService.EnumMemberHasFlagTerm"" />
        <Annotation Term=""ConstantAnnotationService.EnumMemberTerm"" />
      </EntityType>
      <EntityType Name=""ETForNullAsElement"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Annotation Term=""ConstantAnnotationService.BinaryTerm"">
          <Null />
        </Annotation>
        <Annotation Term=""ConstantAnnotationService.StringTerm"">
          <Null />
        </Annotation>
      </EntityType>
      <EntityContainer Name=""ConstantAnnotationContainer""></EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for ETForConstAsElementPlusSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForConstAsElementSingle")]
    public partial class ETForConstAsElementPlusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ETForConstAsElementPlus>
    {
        /// <summary>
        /// Initialize a new ETForConstAsElementPlusSingle object.
        /// </summary>
        public ETForConstAsElementPlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new ETForConstAsElementPlusSingle object.
        /// </summary>
        public ETForConstAsElementPlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }
    }
    /// <summary>
    /// There are no comments for ETForConstAsElementPlus in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdPlus
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForConstAsElement")]
    public partial class ETForConstAsElementPlus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ETForConstAsElementPlus object.
        /// </summary>
        /// <param name="ID">Initial value of IdPlus.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static ETForConstAsElementPlus CreateETForConstAsElementPlus(int ID)
        {
            ETForConstAsElementPlus eTForConstAsElementPlus = new ETForConstAsElementPlus();
            eTForConstAsElementPlus.IdPlus = ID;
            return eTForConstAsElementPlus;
        }
        /// <summary>
        /// There are no comments for Property IdPlus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int IdPlus
        {
            get
            {
                return this._IdPlus;
            }
            set
            {
                this.OnIdPlusChanging(value);
                this._IdPlus = value;
                this.OnIdPlusChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _IdPlus;
        partial void OnIdPlusChanging(int value);
        partial void OnIdPlusChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ETForConstAsAttributePlusSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForConstAsAttributeSingle")]
    public partial class ETForConstAsAttributePlusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ETForConstAsAttributePlus>
    {
        /// <summary>
        /// Initialize a new ETForConstAsAttributePlusSingle object.
        /// </summary>
        public ETForConstAsAttributePlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new ETForConstAsAttributePlusSingle object.
        /// </summary>
        public ETForConstAsAttributePlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }
    }
    /// <summary>
    /// There are no comments for ETForConstAsAttributePlus in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdPlus
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForConstAsAttribute")]
    public partial class ETForConstAsAttributePlus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ETForConstAsAttributePlus object.
        /// </summary>
        /// <param name="ID">Initial value of IdPlus.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static ETForConstAsAttributePlus CreateETForConstAsAttributePlus(int ID)
        {
            ETForConstAsAttributePlus eTForConstAsAttributePlus = new ETForConstAsAttributePlus();
            eTForConstAsAttributePlus.IdPlus = ID;
            return eTForConstAsAttributePlus;
        }
        /// <summary>
        /// There are no comments for Property IdPlus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int IdPlus
        {
            get
            {
                return this._IdPlus;
            }
            set
            {
                this.OnIdPlusChanging(value);
                this._IdPlus = value;
                this.OnIdPlusChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _IdPlus;
        partial void OnIdPlusChanging(int value);
        partial void OnIdPlusChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ETForConstWithDefaultValuePlusSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForConstWithDefaultValueSingle")]
    public partial class ETForConstWithDefaultValuePlusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ETForConstWithDefaultValuePlus>
    {
        /// <summary>
        /// Initialize a new ETForConstWithDefaultValuePlusSingle object.
        /// </summary>
        public ETForConstWithDefaultValuePlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new ETForConstWithDefaultValuePlusSingle object.
        /// </summary>
        public ETForConstWithDefaultValuePlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }
    }
    /// <summary>
    /// There are no comments for ETForConstWithDefaultValuePlus in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdPlus
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForConstWithDefaultValue")]
    public partial class ETForConstWithDefaultValuePlus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ETForConstWithDefaultValuePlus object.
        /// </summary>
        /// <param name="ID">Initial value of IdPlus.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static ETForConstWithDefaultValuePlus CreateETForConstWithDefaultValuePlus(int ID)
        {
            ETForConstWithDefaultValuePlus eTForConstWithDefaultValuePlus = new ETForConstWithDefaultValuePlus();
            eTForConstWithDefaultValuePlus.IdPlus = ID;
            return eTForConstWithDefaultValuePlus;
        }
        /// <summary>
        /// There are no comments for Property IdPlus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int IdPlus
        {
            get
            {
                return this._IdPlus;
            }
            set
            {
                this.OnIdPlusChanging(value);
                this._IdPlus = value;
                this.OnIdPlusChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _IdPlus;
        partial void OnIdPlusChanging(int value);
        partial void OnIdPlusChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ETForNullAsElementPlusSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForNullAsElementSingle")]
    public partial class ETForNullAsElementPlusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ETForNullAsElementPlus>
    {
        /// <summary>
        /// Initialize a new ETForNullAsElementPlusSingle object.
        /// </summary>
        public ETForNullAsElementPlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new ETForNullAsElementPlusSingle object.
        /// </summary>
        public ETForNullAsElementPlusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }
    }
    /// <summary>
    /// There are no comments for ETForNullAsElementPlus in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdPlus
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ETForNullAsElement")]
    public partial class ETForNullAsElementPlus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ETForNullAsElementPlus object.
        /// </summary>
        /// <param name="ID">Initial value of IdPlus.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static ETForNullAsElementPlus CreateETForNullAsElementPlus(int ID)
        {
            ETForNullAsElementPlus eTForNullAsElementPlus = new ETForNullAsElementPlus();
            eTForNullAsElementPlus.IdPlus = ID;
            return eTForNullAsElementPlus;
        }
        /// <summary>
        /// There are no comments for Property IdPlus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int IdPlus
        {
            get
            {
                return this._IdPlus;
            }
            set
            {
                this.OnIdPlusChanging(value);
                this._IdPlus = value;
                this.OnIdPlusChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _IdPlus;
        partial void OnIdPlusChanging(int value);
        partial void OnIdPlusChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for AccessLevelPlus in the schema.
    /// </summary>
    [global::System.Flags]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AccessLevel")]
    public enum AccessLevelPlus
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("Read")]
        ReadPlus = 1,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Write")]
        WritePlus = 2,
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReadWrite")]
        ReadWritePlus = 3
    }
    /// <summary>
    /// There are no comments for ColorPlus in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Color")]
    public enum ColorPlus
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("Red")]
        RedPlus = 0,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Yellow")]
        YellowPlus = 1,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Blue")]
        BluePlus = 2
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlus> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlus> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsElementPlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlus> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlus> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstAsAttributePlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlus> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlus> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForConstWithDefaultValuePlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlus> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlus as global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlusSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlusSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlus> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.Client.TDDUnitTests.Tests.Annotation.ConstantAnnotationProxy.ETForNullAsElementPlusSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}