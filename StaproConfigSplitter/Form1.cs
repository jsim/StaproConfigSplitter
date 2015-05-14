using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaproConfigSplitter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bSplit_Click( object sender, EventArgs e ) {
            split( tbMealTypes, rtbMealTypes, "smealtype", "tmpStapro", "ourid" );
            split( tbWards, rtbWards, "sward", "tmpStapro", "ourid" );
            split( tbDiets, rtbDiets, "sdiet", "tmpStapro", "ourid" );
            split( tbAdditions, rtbAdditions, "sadd", "tmpStapro", "ourid" );
        }

        private void split( TextBox source, RichTextBox target, string column, string table, string idColumn ) {

            target.Clear();

            string s = source.Text;

            if ( string.IsNullOrEmpty( s ) ) {
                return;
            }

            string[] lines = s.Split( ':' );

            foreach ( var line in lines ) {

                if ( string.IsNullOrEmpty( line ) ) {
                    continue;
                }

                string[] kvp = line.Split( '=' );

                string result = string.Format( "INSERT INTO {0} ( {1}, {2} ) VALUES ( '{3}', {4} );\n", table, column, idColumn, kvp[0], kvp[1] );

                target.AppendText( result );

            }

        }
    }
}
