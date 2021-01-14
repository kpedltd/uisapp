using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Forms.TestCreate
{
    public class TestQuestionModel
    {
        /// <summary>
        /// Вопрос
        /// </summary>
        [JsonProperty("question")]
        public string Question
        {
            get;
            set;
        }

        /// <summary>
        /// Ответы
        /// </summary>
        [JsonProperty("answers")]
        public IList<string> Answers
        {
            get;
            set;
        }

        /// <summary>
        /// Индекс верного ответа
        /// </summary>
        [JsonProperty("correct")]
        public int CorrectAnswer
        {
            get;
            set;
        }
    }

    public class TestModel
    {
        /// <summary>
        /// Время на тест
        /// </summary>
        [JsonProperty("testTime")]
        public int TestTime
        {
            get;
            set;
        }

        /// <summary>
        /// Проценты на оценки
        /// </summary>
        [JsonProperty("resultRequirements")]
        public IList<int> ResultRequirements
        {
            get;
            set;
        }

        /// <summary>
        /// Вопросы
        /// </summary>
        [JsonProperty("questions")]
        public IList<TestQuestionModel> Questions
        {
            get;
            set;
        }
    }
}
