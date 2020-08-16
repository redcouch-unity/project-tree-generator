using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System.Linq;

namespace RedCouch.ProjectTreeGenerator {
    class FolderPath {
        public List<string> segments { get; set; }
        public string parentPath {
            get {
                var list = new List<string>(segments);

                list.RemoveAt(list.Count - 1);

                return string.Join(Path.DirectorySeparatorChar.ToString(), list.ToArray());
            }
        }
        public string path {
            get {
                return string.Join(Path.DirectorySeparatorChar.ToString(), segments.ToArray());
            }
        }

        public FolderPath(params string[] segments) : this(segments.ToList()) { }

        public FolderPath(List<string> segments) {
            this.segments = segments;
        }
    }

    public class ProjectTreeGenerator {
        [MenuItem("Tools/Generate Project Tree/With .keep")]
        public static void GenerateWithoutKeep() {
            Generate(true);
        }

        [MenuItem("Tools/Generate Project Tree/Without .keep")]
        public static void GenerateWithKeep() {
            Generate(false);
        }

        public static void Generate(bool keepEmptyFolders) {
            foreach (var folder in GetFolders()) {
                var path = folder.path;

                if (!AssetDatabase.IsValidFolder(path)) {
                    AssetDatabase.CreateFolder(folder.parentPath, folder.segments.Last());

                    if (keepEmptyFolders) {
                        File.Create(path + Path.DirectorySeparatorChar + ".keep");
                    }
                } else {
                    if (Directory.GetFiles(path).Length == 0 && keepEmptyFolders) {
                        File.Create(path + Path.DirectorySeparatorChar + ".keep");
                    }
                }
            }
        }

        private static List<FolderPath> GetFolders() {
            return new List<FolderPath> {
                new FolderPath("Assets","Editor"),
                new FolderPath("Assets","Plugins"),
                new FolderPath("Assets","Resources"),
                new FolderPath("Assets","Resources","Prefabs"),
                new FolderPath("Assets","Scenes"),
                new FolderPath("Assets","Scripts"),
                new FolderPath("Assets","Scripts","Actors"),
                new FolderPath("Assets","Scripts","Behaviours"),
                new FolderPath("Assets","Scripts","Core"),
                new FolderPath("Assets","Scripts","Core","Models"),
                new FolderPath("Assets","Scripts","Helpers"),
                new FolderPath("Assets","Scripts","Managers"),
                new FolderPath("Assets","Scripts","Menu"),
                new FolderPath("Assets","Scripts","UI"),
                new FolderPath("Assets","Scripts","UI","Components"),
                new FolderPath("Assets","Scripts","Utils"),
                new FolderPath("Assets","Static"),
                new FolderPath("Assets","Static","Animations"),
                new FolderPath("Assets","Static","Effects"),
                new FolderPath("Assets","Static","Fonts"),
                new FolderPath("Assets","Static","Materials"),
                new FolderPath("Assets","Static","Models"),
                new FolderPath("Assets","Static","Models"),
                new FolderPath("Assets","Static","Music"),
                new FolderPath("Assets","Static","Prefabs"),
                new FolderPath("Assets","Static","Shaders"),
                new FolderPath("Assets","Static","Sounds"),
                new FolderPath("Assets","Static","Sprites"),
                new FolderPath("Assets","Static","Textures"),
                new FolderPath("Assets","Static","Videos"),
                new FolderPath("Assets","ThirdParty"),
            };
        }
    }
}