using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Reflection;
using Xamarin.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tg2_Dev_2
{
    public class App : Application
    {
        string schema;
        public App()
        {

            schema = @"{
                                'Fields':[
                                 {
                                    'FieldName':'lblEventId',
                                    'FieldType':'Label',
                                    'FieldValue': 'EventId'
                                 },
                                 {
                                    'FieldName':'lblEventIdValue',
                                    'FieldType':'Label',
                                    'FieldValue': 'E-101'
                                 },
                                 {
                                    'FieldName' : 'lblProjectId',
                                    'FieldType' : 'Label',
                                    'FieldValue': 'ProjectId'
                                 },
                                 {
                                    'FieldName' : 'txtProjectId',
                                    'FieldType' : 'Entry',
                                    'FieldValue': ''
                                 },
                                 {
                                    'FieldName' : 'btnSubmit',
                                    'FieldType' : 'Button',
                                    'FieldValue' : 'Submit'
                                 }

                                ]
                              }";
            MainPage = new EventsPage(schema);
        }

        protected override void OnStart()
        {
             
        }
        protected override void OnSleep() { }
        protected override void OnResume() { }
    }
   
}
